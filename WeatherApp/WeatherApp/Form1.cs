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
        private Timer timerDateTime;
        #region API Key
        private string APIKey = "68d42b9ada53b7dacca41373c7c14a71"; // API key
        #endregion
        private HttpClient httpClient = new HttpClient(); // Tạo HttpClient một lần duy nhất
        public Form1()
        {
            InitializeComponent();

            // Khởi tạo timer cho đồng hồ
            timerDateTime = new Timer { Interval = 1000 };
            EventHandler timerDateTime_Tick = TimerDateTime_Tick;
            timerDateTime.Tick += timerDateTime_Tick;
            timerDateTime.Start();

            // Bắt sự kiện khi nhấn Enter trong TextBox thành phố
            TBCity.KeyPress += TBCity_KeyPress;

            // Khởi tạo DataGridView
            InitializeDataGridView();

            // Khởi tạo AutoComplete
            NewMethod();

            // Lấy thông tin thời tiết cho vị trí hiện tại
            GetCurrentLocationWeather();
        }

        private void GetCurrentLocationWeather()
        {
            throw new NotImplementedException();
        }

        private void UpdateCurrentWeather(root currentInfo)
        {
            picIcon.LoadAsync("https://openweathermap.org/img/wn/" + currentInfo.weather[0].icon + ".png"); // Sử dụng LoadAsync
            labCondition.Text = currentInfo.weather[0].main;
            labDetail.Text = currentInfo.weather[0].description;
            labSunset.Text = convertDatime(currentInfo.sys.sunset).ToShortTimeString();
            labSunrise.Text = convertDatime(currentInfo.sys.sunrise).ToShortTimeString();
            labTemp_max.Text = $"{currentInfo.main.temp_max - 273.15} °C";
            labTemp_min.Text = $"{currentInfo.main.temp_min - 273.15} °C";
            double tempCelsius = currentInfo.main.temp - 273.15;
            labTemperature.Text = $"{tempCelsius:0.#}°C";
            labWindSpeed.Text = $"{currentInfo.wind.speed} m/s";
            labPressure.Text = $"{currentInfo.main.pressure} hPa";
            labHumidity.Text = $"{currentInfo.main.humidity} %";
            labFeels_like.Text = $"{currentInfo.main.feels_like - 273.15} °C";
            labSeaLevel.Text = $"{currentInfo.main.sea_level} hPa";
            labGrndLevel.Text = $"{currentInfo.main.grnd_level} hPa";

            UpdateWeatherAdvice(currentInfo.weather[0].description.ToLower());
        }

        private void UpdateWeatherAdvice(object value)
        {
            throw new NotImplementedException();
        }

        private static void NewMethod()
        {
            SetupAutoComplete();
        }

        private static void SetupAutoComplete()
        {
            throw new NotImplementedException();
        }

        // Khởi tạo DataGridView
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
                HeaderText = "",
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dataGridView1.Columns.Add(weatherIconColumn);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView1.Columns["Date"].Width = 80;
            dataGridView1.Columns["Time"].Width = 60;
            dataGridView1.Columns["Temperature"].Width = 50;
            dataGridView1.Columns["Condition"].Width = 120;
            dataGridView1.Columns["WeatherIcon"].Width = 70;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        // Xử lý sự kiện khi nhấn nút Search
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await GetWeatherByCity();
        }

        // Xử lý sự kiện khi nhấn Enter trong TextBox thành phố
        private async void TBCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                await GetWeatherByCity();
                e.Handled = true;
            }
        }

        // Lấy thông tin thời tiết dựa trên tên thành phố
        private async Task GetWeatherByCity()
        {
            string city = TBCity.Text.Trim();

            if (string.IsNullOrWhiteSpace(city))
            {
                MessageBox.Show("Vui lòng nhập tên thành phố hợp lệ.");
                return;
            }

            try
            {
                // Lấy thông tin thời tiết hiện tại
                string weatherUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={APIKey}";
                var weatherJson = await httpClient.GetStringAsync(weatherUrl);
                root currentInfo = JsonConvert.DeserializeObject<root>(weatherJson);

                // Lấy thông tin dự báo thời tiết
                string forecastUrl = $"https://api.openweathermap.org/data/2.5/forecast?q={city}&appid={APIKey}";
                var forecastJson = await httpClient.GetStringAsync(forecastUrl);
                ForecastRoot forecastInfo = JsonConvert.DeserializeObject<ForecastRoot>(forecastJson);

                // Cập nhật giao diện
                UpdateCurrentWeather(currentInfo);
                UpdateForecast(forecastInfo); // Chờ UpdateForecast hoàn thành
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            finally
            {
                TBCity.Clear();
            }
        }

        private void UpdateForecast(ForecastRoot forecastInfo)
        {
            throw new NotImplementedException();
        }


        // Chuyển đổi Unix Timestamp sang DateTime
        private DateTime convertDatime(long millisec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            return day.AddSeconds(millisec).ToLocalTime();
        }

        // Xử lý sự kiện tick của timer đồng hồ
        private void TimerDateTime_Tick(object sender, EventArgs e)
        {
            labDateTime.Text = DateTime.Now.ToString("HH:mm");
            labDateTime2.Text = DateTime.Now.ToString("dddd, dd - M - yyyy");
        }
        // Xử lý sự kiện khi nhấn nút Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
