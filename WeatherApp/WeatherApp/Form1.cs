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
