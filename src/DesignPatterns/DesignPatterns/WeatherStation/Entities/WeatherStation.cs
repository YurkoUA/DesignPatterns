using System.Collections.Generic;
using WeatherStation.Interfaces;
using WeatherStation.Models;

namespace WeatherStation.Entities
{
    public class WeatherStation : ISubject
    {
        private WeatherData _weatherData;
        private List<IObserver> _observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            _observers.ForEach(obs => obs.Update(_weatherData));
        }

        public void UpdateWeatherData(WeatherData weatherData)
        {
            _weatherData = weatherData;
            OnMeasurementsChange();
        }

        private void OnMeasurementsChange()
        {
            NotifyObservers();
        }
    }
}
