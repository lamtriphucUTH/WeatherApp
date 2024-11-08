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

        // Hàm lấy thông tin thời tiết theo thành phố 
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
                // Lấy thông tin thời tiết hiện tại và dự báo
                var currentInfo = await GetCurrentWeather(city);
                var forecastInfo = await GetForecast(city);

                // Cập nhật giao diện
                UpdateCurrentWeather(currentInfo);
                await UpdateForecast(forecastInfo);

                // Kiểm tra và hiển thị thông báo thiên tai
                foreach (var weather in currentInfo.weather)
                {
                    if (weather.description.Contains("storm") && !stormWarningDisplayed)
                    {
                        stormWarningDisplayed = true;
                        ShowWarningMessage("Cảnh báo bão!");
                        break;
                    }
                    else if (weather.description.Contains("earthquake") && !earthquakeWarningDisplayed)
                    {
                        earthquakeWarningDisplayed = true;
                        ShowWarningMessage("Cảnh báo động đất!");
                        break;
                    }
                    else if (weather.description.Contains("tsunami") && !tsunamiWarningDisplayed)
                    {
                        tsunamiWarningDisplayed = true;
                        ShowWarningMessage("Cảnh báo sóng thần!");
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        //Hàm lấy thông tin thời tiết theo thành phố
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
                // Lấy thông tin thời tiết hiện tại và dự báo
                var currentInfo = await GetCurrentWeather(city);
                var forecastInfo = await GetForecast(city);

                // Cập nhật giao diện
                UpdateCurrentWeather(currentInfo);
                await UpdateForecast(forecastInfo);

                // Kiểm tra và hiển thị thông báo thiên tai
                foreach (var weather in currentInfo.weather)
                {
                    if (weather.description.Contains("storm") && !stormWarningDisplayed)
                    {
                        stormWarningDisplayed = true;
                        ShowWarningMessage("Cảnh báo bão!");
                        break;
                    }
                    else if (weather.description.Contains("earthquake") && !earthquakeWarningDisplayed)
                    {
                        earthquakeWarningDisplayed = true;
                        ShowWarningMessage("Cảnh báo động đất!");
                        break;
                    }
                    else if (weather.description.Contains("tsunami") && !tsunamiWarningDisplayed)
                    {
                        tsunamiWarningDisplayed = true;
                        ShowWarningMessage("Cảnh báo sóng thần!");
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
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

        // Xử lý sự kiện khi nhấn nút Search hoặc Enter trong TextBox thành phố
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
                e.Handled = true; // Ngăn chặn âm thanh "ding" khi nhấn Enter
            }
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
        //Xử lý sự kiện khi nhấn nút Show
        private void btnShow_Click(object sender, EventArgs e)
        {
            string city = TBCity.Text.Trim();
            if (!string.IsNullOrWhiteSpace(city))
            {
                GetCurrentLocationWeather();
            }
        }
        

        //Biến để kiểm tra xem cảnh báo bão đã được hiển thị hay chưa
        private bool stormWarningDisplayed = false; // Cảnh báo bão
        private bool earthquakeWarningDisplayed = false;// Cảnh báo động đất
        private bool tsunamiWarningDisplayed = false;// Cảnh báo sóng thần


        //26. Hàm để cập nhật lời khuyên(Minh)
        private void UpdateWeatherAdvice(string condition)
        {
            switch (condition)
            {
                case "light rain":
                    labDetail2.Text = "Mưa nhỏ";
                    labAdvice.Text = "Trời mưa nhẹ, bạn nên mang theo ô đề phòng.";
                    break;
                case "scattered clouds":
                    labDetail2.Text = "Mây rải rác";
                    labAdvice.Text = "Trời có mây rải rác, bạn có thể thoải mái đi lại.";
                    break;
                case "broken clouds":
                    labDetail2.Text = "Mây rải rác";
                    labAdvice.Text = "Trời có mây rải rác, bạn có thể thoải mái đi lại.";
                    break;
                case "light intensity drizzle":
                    labDetail2.Text = "Mưa phùn nhỏ";
                    labAdvice.Text = "Trời mưa phùn nhỏ, bạn nên mang theo ô đề phòng.";
                    break;
                case "drizzle":
                    labDetail2.Text = "Mưa phùn";
                    labAdvice.Text = "Trời mưa phùn, bạn nên mang theo ô đề phòng.";
                    break;
                case "heavy intensity drizzle":
                    labDetail2.Text = "Mưa phùn lớn";
                    labAdvice.Text = "Trời mưa phùn lớn, bạn nên mang theo ô đề phòng.";
                    break;
                case "clear sky":
                    labDetail2.Text = "Trời quang đãng";
                    labAdvice.Text = "Trời quang đãng, bạn có thể thoải mái đi lại.";
                    break;
                case "few clouds":
                    labDetail2.Text = "Ít mây";
                    labAdvice.Text = "Trời có ít mây, bạn có thể thoải mái đi lại.";
                    break;
                case "overcast clouds":
                    labDetail2.Text = "Trời âm u";
                    labAdvice.Text = "Trời có mưa, bạn nên mang theo ô đề phòng.";
                    break;
                case "moderate rain":
                    labDetail2.Text = "Mưa nhỏ";
                    labAdvice.Text = "Trời sẽ mưa , bạn nên mang theo ô đề phòng.";
                    break;
                case "heavy intensity rain":
                    labDetail2.Text = "Mưa lớn";
                    labAdvice.Text = "Trời mưa lớn, bạn nên mang theo ô đề phòng.";
                    break;
                case "snow":
                    labDetail2.Text = "Tuyết";
                    labAdvice.Text = "Trời có tuyết, bạn nên mang theo áo ấm.";
                    break;
                case "mist":
                    labDetail2.Text = "Sương mù";
                    labAdvice.Text = "Trời có sương mù, bạn nên chú ý khi lái xe.";
                    break;
                case "haze":
                    labDetail2.Text = "Sương mù";
                    labAdvice.Text = "Trời có sương mù, bạn nên chú ý khi lái xe.";
                    break;
                case "light intensity shower rain":
                    labDetail2.Text = "Mưa rào";
                    labAdvice.Text = "Trời có mưa rào, bạn nên mang theo ô đề phòng.";
                    break;
                case "shower rain":
                    labDetail2.Text = "Mưa rào";
                    labAdvice.Text = "Trời có mưa rào, bạn nên mang theo ô đề phòng.";
                    break;
                case "heavy intensity shower rain":
                    labDetail2.Text = "Mưa rào lớn";
                    labAdvice.Text = "Trời có mưa rào lớn, bạn nên mang theo ô đề phòng.";
                    break;
                case "fog":
                    labDetail2.Text = "Sương mù";
                    labAdvice.Text = "Trời có sương mù, bạn nên chú ý khi lái xe.";
                    break;
                case "thunderstorm":
                    labDetail2.Text = "Dông";
                    labAdvice.Text = "Trời có dông, bạn nên ở trong nhà.";
                    break;
                case "clouds":
                    labDetail2.Text = "Mây";
                    labAdvice.Text = "Trời có mây, bạn có thể thoải mái đi lại.";
                    break;
                case "thunderstorm with light rain":
                    labDetail2.Text = "Dông và mưa nhỏ";
                    labAdvice.Text = "Trời có dông với mưa nhỏ, bạn nên ở trong nhà.";
                    break;
                case "thunderstorm with rain":
                    labDetail2.Text = "Dông và mưa";
                    labAdvice.Text = "Trời có dông với mưa, bạn nên ở trong nhà.";
                    break;
                case "thunderstorm with heavy rain":
                    labDetail2.Text = "Dông với mưa lớn";
                    labAdvice.Text = "Trời có dông với mưa lớn, bạn nên ở trong nhà.";
                    break;
                case "thunderstorm with light drizzle":
                    labDetail2.Text = "Dông với mưa phùn nhỏ";
                    labAdvice.Text = "Trời có dông với mưa, bạn nên ở trong nhà .";
                    break;
                case "thunderstorm with drizzle":
                    labDetail2.Text = "Dông với mưa phùn";
                    labAdvice.Text = "Trời có dông và mưa phùn, bạn nên ở trong nhà.";
                    break;
                case "thunderstorm with heavy drizzle":
                    labDetail2.Text = "Dông với mưa phùn lớn";
                    labAdvice.Text = "Trời có dông và mưa lớn, bạn nên ở trong nhà.";
                    break;
                case "light snow":
                    labDetail2.Text = "Tuyết nhẹ";
                    labAdvice.Text = "Trời có tuyết, bạn nên mang theo áo ấm.";
                    break;
                case "overcast":
                    labDetail2.Text = "Trời âm u";
                    labAdvice.Text = "Trời sẽ có mưa, bạn nên mang theo ô đề phòng.";
                    break;
            
            }
        }


        //16. Hàm cập nhật hình nền 
        private void UpdateBackground(string weatherCondition)
        {
            string backgroundImage = "nang.jpg"; // Hình nền mặc định

            switch (weatherCondition.ToLower())
            {
                case "rain":
                case "drizzle":
                case "thunderstorm":
                case "light rain":
                case "thunderstorm with light drizzle":
                case "thunderstorm with light rain":
                case "moderate rain":
                    backgroundImage = "mua2.jpg"; // Hình nền trời mưa
                    break;
                case "shower rain":
                case "light intensity shower rain":
                case "heavy intensity shower rain":
                    backgroundImage = "mua2.jpg"; // Hình nền trời mưa
                    break;
                case "clouds":
                case "overcast clouds":
                case "overcast":
                    backgroundImage = "amu.jpg";
                    break;
                case "heavy intensity rain":
                case "thunderstorm with rain":
                case "thunderstorm with heavy rain":
                    backgroundImage = "mua2.jpg"; // Hình nền trời mưa
                    break;
                case "clear":
                case "clear sky":
                    backgroundImage = "nang2.jpg"; // Hình nền trời nắng
                    break;
                case "scattered clouds":
                case "broken clouds":// ít mấy
                case "few clouds":
                    backgroundImage = "may.jpg"; // Hình nền trời nhiều mây
                    break;
                case "snow":
                    backgroundImage = "tuyet.jpg"; // Hình nền trời tuyết
                    break;

                case "mist":
                case "haze":
                case "fog":
                case "light intensity drizzle":
                case "heavy intensity drizzle":
                    backgroundImage = "suongmu.jpg"; // Hình nền sương mù
                    break;
            }

            // Kiểm tra xem file ảnh có tồn tại hay không trước khi gán cho BackgroundImage
            if (File.Exists(backgroundImage))
            {
                this.BackgroundImage = Image.FromFile(backgroundImage);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                MessageBox.Show($"Không tìm thấy hình nền: {backgroundImage}");
            }
        }

        //Lấy dữ liệu hình ảnh từ URL 
        private async Task<Bitmap> GetImageFromUrl(string url)
        {
            using (var response = await httpClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    using (var stream = await response.Content.ReadAsStreamAsync())
                    {
                        return new Bitmap(stream);
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        //Cập nhật DataGridView và biểu đồ với thông tin dự báo thời tiết
        private async Task UpdateForecast(ForecastRoot forecastInfo)
        {
            dataGridView1.Rows.Clear();
            temperatureSeriesCollection.Clear();

            // Tạo danh sách dữ liệu dự báo cho 7 ngày tiếp theo
            var next7DaysForecasts = forecastInfo.list
                .GroupBy(forecast => DateTimeOffset.FromUnixTimeSeconds(forecast.dt).Date)
                .Take(7)
                .Select(group => group.First()) // lấy dữ liệu đầu tiên trong mỗi nhóm
                .ToList();

            List<Task<Bitmap>> imageTasks = new List<Task<Bitmap>>();
            ChartValues<ObservablePoint> chartValues = new ChartValues<ObservablePoint>();
            labels = new string[next7DaysForecasts.Count]; // Cập nhật lại kích thước của labels

            for (int i = 0; i < next7DaysForecasts.Count; i++)
            {
                var forecast = next7DaysForecasts[i];
                DateTime forecastDateTime = ConvertDateTime(forecast.dt);
                double tempCelsius = forecast.main.temp - 273.15;
                string condition = forecast.weather[0].description;
                string iconUrl = $"https://openweathermap.org/img/wn/{forecast.weather[0].icon}@2x.png";

                imageTasks.Add(GetImageFromUrl(iconUrl));

                int rowIndex = dataGridView1.Rows.Add(
                    forecastDateTime.ToShortDateString(),
                    forecastDateTime.ToShortTimeString(),
                    $"{tempCelsius:0.#}°C",
                    condition,
                    null
                );

                dataGridView1.Rows[rowIndex].Tag = imageTasks.Last();

                // thêm dữ liệu vào biểu đồ
                chartValues.Add(new ObservablePoint { X = i, Y = tempCelsius });
                labels[i] = forecastDateTime.ToString("dd/MM"); // cập nhật nhãn cho trục X
            }

            // Update weather icons in DataGridView
            Bitmap[] weatherIconsForGrid = await Task.WhenAll(imageTasks);
            for (int i = 0; i < weatherIconsForGrid.Length; i++)
            {
                if (dataGridView1.Rows.Count > i)
                {
                    dataGridView1.Rows[i].Cells["WeatherIcon"].Value = weatherIconsForGrid[i];
                }
            }

            // cập nhật dữ liệu cho biểu đồ
            LineSeries series = new LineSeries
            {
                Title = "Nhiệt độ",
                Values = chartValues,
                PointGeometry = DefaultGeometries.Circle,
                PointGeometrySize = 15,
                DataLabels = true,
                LabelPoint = point => $"{point.Y:0.#}°C",
                Fill = System.Windows.Media.Brushes.Transparent
            };

            temperatureSeriesCollection.Add(series);
            cartesianChart1.Series = temperatureSeriesCollection;

            // Update labels for the X axis
            cartesianChart1.AxisX[0].Labels = labels;
        }
    }
}



