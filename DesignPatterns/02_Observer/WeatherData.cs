using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02_Observer
{
    public class WeatherData : IWeatherData
    {
        private float _temp;
        private float _humidity;
        private float _pressure;
        private ICollection<IObserver> _activeObservers = new List<IObserver>();

        public void RegisterObserver(IObserver observer)
        {
            this._activeObservers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            this._activeObservers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _activeObservers)
            {
                observer.Update(_humidity, _temp, _pressure);
            }
        }

        public void MeasurementsChanged()
        {
            this._humidity = GetHumidity();
            this._pressure = GetPressure();
            this._temp = GetTemp();
            NotifyObservers();
        }

        public float GetTemp()
        {
            return 5.00f;
        }

        public float GetPressure()
        {
            return 4.00f;
        }

        public float GetHumidity()
        {
            return 3.00f;
        }
    }
}
