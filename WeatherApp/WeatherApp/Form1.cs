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

    }
}
