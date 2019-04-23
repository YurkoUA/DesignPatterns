using System;
using WeatherStation.Entities;
using WeatherStation.Models;

namespace WeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            var station = new Entities.WeatherStation();
            var currentWeather = new CurrentWeatherScreen(station);
            var statisticsWeather = new StatisticsWeatherScreen(station);

            while (true)
            {
                WeatherData data = InputWeatherData();
                station.UpdateWeatherData(data);
            }
        }

        static WeatherData InputWeatherData()
        {
            var data = new WeatherData();

            Console.Write("Temperature: ");
            data.Temperature = decimal.Parse(Console.ReadLine());

            Console.Write("Humidity: ");
            data.Humidity = decimal.Parse(Console.ReadLine());

            Console.Write("Pressure: ");
            data.Pressure = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            return data;
        }
    }
}
