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
    }
}



