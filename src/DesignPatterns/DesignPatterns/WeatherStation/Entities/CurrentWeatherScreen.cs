using System;
using WeatherStation.Interfaces;
using WeatherStation.Models;

namespace WeatherStation.Entities
{
    public class CurrentWeatherScreen : IObserver, IDisplayElement
    {
        private ISubject _weatherStation;
        private WeatherData _weatherData;

        public CurrentWeatherScreen(ISubject weatherStation)
        {
            _weatherStation = weatherStation;
            weatherStation.AddObserver(this);
        }

        public void Update(WeatherData weatherData)
        {
            _weatherData = weatherData;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Temperature: {_weatherData.Temperature}");
            Console.WriteLine($"Humidity: {_weatherData.Humidity}");
            Console.WriteLine($"Pressure: {_weatherData.Pressure}");
            Console.WriteLine();
        }
    }
}
