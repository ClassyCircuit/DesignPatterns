using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02_Observer
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float _averageTemp;
        private float _maxTemp = 0;
        private float _minTemp = 0;
        private int _numberOfReadings = 0;
        private IWeatherData weatherData;
        private WeatherDataObject _dataObject;

        public StatisticsDisplay(IWeatherData wd)
        {
            this.weatherData = wd;
            weatherData.RegisterObserver(this);

            this._dataObject = new WeatherDataObject();

        }

        public void Update(IWeatherData observable, WeatherDataObject obj)
        {
            if (observable is WeatherData && obj != null)
            {
                this._numberOfReadings++;
                if (obj.temp > _maxTemp)
                {
                    this._maxTemp = obj.temp;
                }

                if (obj.temp < _minTemp)
                {
                    this._minTemp = obj.temp;
                }

                this._averageTemp = (_minTemp + _maxTemp) / _numberOfReadings;
            }

            Display();
        }

        public void Display()
        {
            Debug.WriteLine("==Statistics==");
            Debug.WriteLine("Average: "+ _averageTemp);
            Debug.WriteLine("Max temp: "+ _maxTemp);
            Debug.WriteLine("Min temp: "+ _minTemp);
            
          
        }
    }
}
