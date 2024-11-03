using System;
using Newtonsoft.Json;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;
using System.Net.Http;
using System.IO;
using System.Threading.Tasks;
using static Weather_Application.WeatherInfo;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        // Cập nhật API key và tạo biến httpClient
        private Timer timerDateTime;
        #region API Key
        private string APIKey = "68d42b9ada53b7dacca41373c7c14a71"; // API key
        #endregion

        private HttpClient httpClient = new HttpClient();

        // Khởi tạo AutoComplete
        private void SetupAutoComplete()
        {
            TBCity.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TBCity.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        
        //Xử lý sự kiện khi thay đổi nội dung trong TextBox thành phố
        private async void TBCity_TextChanged(object sender, EventArgs e)
        {
            string input = TBCity.Text.Trim();

            if (input.Length >= 3)
            {
                var suggestions = await GetCitySuggestions(input);
                if (suggestions != null)
                {
                    var autoCompleteCollection = new AutoCompleteStringCollection();
                    autoCompleteCollection.AddRange(suggestions.ToArray());
                    TBCity.AutoCompleteCustomSource = autoCompleteCollection;
                }
            }
        }

        // Khởi tạo biểu đồ 
        private void InitializeChart()
        {
            temperatureSeriesCollection = new SeriesCollection();
            labels = new string[7]; // Khởi tạo labels với kích thước ban đầu là 7

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Thời gian",
                Labels = labels
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Nhiệt độ (°C)"
            });

            cartesianChart1.LegendLocation = LegendLocation.Right;
            cartesianChart1.DataClick += (sender, chartPoint) =>
            {
                MessageBox.Show($"Nhiệt độ: {chartPoint.Y}°C");
            };

            // Cho phép hiển thị tooltip khi di chuột qua các điểm trên biểu đồ
            cartesianChart1.Hoverable = true;
        }

        // Khởi tạo DataGridView (Phúc)
        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Date", "Ngày");
            dataGridView1.Columns.Add("Time", "Giờ");
            dataGridView1.Columns.Add("Temperature", "Nhiệt Độ");
            dataGridView1.Columns.Add("Condition", "Trạng Thái");

            var weatherIconColumn = new DataGridViewImageColumn
            {
                Name = "WeatherIcon",
                HeaderText = "Biểu Tượng",
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };

            dataGridView1.Columns.Add(weatherIconColumn);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView1.Columns["Date"].Width = 100;
            dataGridView1.Columns["Time"].Width = 70;
            dataGridView1.Columns["Temperature"].Width = 90;
            dataGridView1.Columns["Condition"].Width = 150;
            dataGridView1.Columns["WeatherIcon"].Width = 100;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }



        //Lấy thông tin thời tiết hiện tại từ OpenWeatherMap API
        private async Task<root> GetCurrentWeather(string city)
        {
            string weatherUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={APIKey}";
            var weatherJson = await httpClient.GetStringAsync(weatherUrl);
            return JsonConvert.DeserializeObject<root>(weatherJson);
        }


        //Xử lý sự kiện khi nhấn nút Reload
        private void butReload_Click(object sender, EventArgs e)
        {
            try
            {
                GetCurrentLocationWeather();
                MessageBox.Show("Tải lại thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}



