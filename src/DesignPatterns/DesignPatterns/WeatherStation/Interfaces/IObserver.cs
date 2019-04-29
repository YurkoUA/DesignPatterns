using WeatherStation.Models;

namespace WeatherStation.Interfaces
{
    public interface IObserver
    {
        void Update(WeatherData weatherData);
    }
}
