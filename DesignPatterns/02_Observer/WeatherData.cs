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
        private ICollection<IObserver> _activeObservers;
        private WeatherDataObject _dataObject;

        public WeatherData()
        {
            this._dataObject = new WeatherDataObject();
            this._activeObservers = new List<IObserver>();
        }
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
                observer.Update(this, _dataObject);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temp, float pressure, float humidity)
        {
            this._dataObject.pressure = pressure;
            this._dataObject.humidity = humidity;
            this._dataObject.temp = temp;
            MeasurementsChanged();
        }
    }
}
