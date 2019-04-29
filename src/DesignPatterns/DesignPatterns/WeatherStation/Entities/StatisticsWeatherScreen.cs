using System;
using System.Collections.Generic;
using System.Linq;
using WeatherStation.Interfaces;
using WeatherStation.Models;

namespace WeatherStation.Entities
{
    public class StatisticsWeatherScreen : IObserver, IDisplayElement
    {
        private ISubject _weatherStation;
        private List<WeatherData> _weatherHistory = new List<WeatherData>();

        public StatisticsWeatherScreen(ISubject weatherStation)
        {
            _weatherStation = weatherStation;
            _weatherStation.AddObserver(this);
        }

        public void Update(WeatherData weatherData)
        {
            _weatherHistory.Add(weatherData);
            Display();
        }

        public void Display()
        {
            var avgTemp = _weatherHistory.Average(h => h.Temperature);
            var avgHumidity = _weatherHistory.Average(h => h.Humidity);
            var avgPressure = _weatherHistory.Average(h => h.Pressure);

            Console.WriteLine($"Avg Temperature: {avgTemp}");
            Console.WriteLine($"Avg Humidity: {avgHumidity}");
            Console.WriteLine($"Avg Pressure: {avgPressure}");
            Console.WriteLine();
        }
    }
}
