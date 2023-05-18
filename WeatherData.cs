using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.Json;
using Newtonsoft.Json;

namespace OpenWeather
{
    public class WeatherData //класс для хранения и предоставления доступа к основным данным о погоде, полученным из API OpenWeatherMap
    {
        [JsonProperty("main")]
        public MainWeatherData Main { get; set; }

        public WindData Wind { get; set; }

        [JsonProperty("weather")]
        public WeatherDescription[] WeatherDescriptions { get; set; }

        public double Temperature => Main?.Temperature ?? 0;  // Получаем температуру из объекта MainWeatherData
        public double WindSpeed => Wind?.Speed ?? 0;  // Получаем скорость ветра из объекта WindData
        public string WeatherDetails => WeatherDescriptions?.Length > 0 ? WeatherDescriptions[0].Description : string.Empty;  // Получаем описание погоды из объекта WeatherDescription
    }
    //классы для представления температуры, скорости ветра и описании погоды
    public class MainWeatherData
    {
        [JsonProperty("temp")] //атрибут для связки имен свойств в классе с именами полей в JSON-документе
        public double Temperature { get; set; }
    }
    public class WindData
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }
    }

    public class WeatherDescription
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
