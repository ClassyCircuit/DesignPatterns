using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02_Observer
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private IWeatherData weatherData;
        private WeatherDataObject _dataObject;

        public CurrentConditionsDisplay(IWeatherData wd)
        {
            this.weatherData = wd;
            weatherData.RegisterObserver(this);

            this._dataObject = new WeatherDataObject();
        }
        public void Update(IWeatherData observable, WeatherDataObject obj)
        {
            if (observable is WeatherData && obj != null)
            {
                this._dataObject = obj;
            }
            Display();
        }

        public void Display()
        {
            Debug.WriteLine("==Current conditions==");
            Debug.WriteLine("Temp: " + _dataObject.temp);
            Debug.WriteLine("Humidity: " + _dataObject.humidity);
        }
    }
}
