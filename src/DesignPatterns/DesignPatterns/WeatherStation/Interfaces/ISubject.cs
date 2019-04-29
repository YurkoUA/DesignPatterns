using WeatherStation.Models;

namespace WeatherStation.Interfaces
{
    public interface ISubject
    {
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();

        void UpdateWeatherData(WeatherData weatherData);
    }
}
