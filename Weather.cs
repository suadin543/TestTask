using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json; //Импорт библиотеки для сериализации JSON

namespace OpenWeather
{

    public partial class Weather : Form
    {
        private const string ApiKey = "6c3ce0064b65de91b5758667ca807fce"; //ключ API openweathermap.org


        
        public Weather()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private async void GetWeather_Click(object sender, EventArgs e)
        {
            string city = City.Text;  // название введенного города
            WeatherData weatherData = await GetWeatherData(city); // Вызываем метод GetWeatherData для получения данных о погоде

            if (weatherData != null) // проверка успешного получения данных
            {
                
                    Temperature.Text = $" {weatherData.Temperature}°C"; // Отображаем температуру в градусах Цельсия
                    WindSpeed.Text = $" {weatherData.WindSpeed} м/с"; // Отображаем скорость ветра в метрах в секунду
                    Details.Text = $" {weatherData.WeatherDetails}"; // Отображаем детали погоды
                
            }
            else
            {
                MessageBox.Show("Не удается получить данные о погоде.");
            }
        }
        private async Task<WeatherData> GetWeatherData(string city) // метод для выполнения асинхронной операции получения данных о погоде для указанного города.
        {
            using (HttpClient client = new HttpClient()) // Создаем экземпляр HttpClient
            {
                try
                {
                    string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={ApiKey}&units=metric"; //для вызова API по названию города
                    HttpResponseMessage response = await client.GetAsync(url); // Отправляем HTTP GET-запрос к API OpenWeatherMap

                    if (response.IsSuccessStatusCode) // если успешно завершился HTTP-овтет
                    {
                        string responseContent = await response.Content.ReadAsStringAsync(); // Читаем содержимое ответа в виде строки
                        WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(responseContent); // Десериализуем JSON-ответ в объект WeatherData
                        return weatherData;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
            }

            return null;
        }
        

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

