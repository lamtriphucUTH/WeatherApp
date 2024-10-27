using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            timerDateTime.Tick += TimerDateTime_Tick;
            timerDateTime.Start();

            // Bắt sự kiện khi nhấn Enter trong TextBox thành phố
            TBCity.KeyPress += TBCity_KeyPress;

            // Khởi tạo DataGridView
            InitializeDataGridView();

            // Khởi tạo AutoComplete
            SetupAutoComplete();

            // Lấy thông tin thời tiết cho vị trí hiện tại
            GetCurrentLocationWeather();
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



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butReload_Click(object sender, EventArgs e)
        {

        }

        private void labSunrise_Click(object sender, EventArgs e)
        {

        }
    }
}
