using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02_Observer
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {

        private float _lastPressure = 0.00f;
        private IWeatherData weatherData;
        private WeatherDataObject _dataObject;
        public ForecastDisplay(IWeatherData wd)
        {
            this.weatherData = wd;
            weatherData.RegisterObserver(this);

            this._dataObject = new WeatherDataObject();
        }

        public void Update(IWeatherData observable, WeatherDataObject obj)
        {
            if (observable is WeatherData && obj != null)
            {
                this._lastPressure = _dataObject.pressure;
                this._dataObject = obj;
            }
            Display();
        }

        public void Display()
        {
            Debug.WriteLine("==Forecast==");
            if (_dataObject.pressure > _lastPressure)
            {
                Debug.WriteLine("Weather is going to improve!");
            }
            else if (_dataObject.pressure == _lastPressure)
            {
                Debug.WriteLine("Same weather ahead!");
            }
            else if (_dataObject.pressure < _lastPressure)
            {
                Debug.WriteLine("Weather is going to get worse!");
            }

        }
    }
}
