using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02_Observer
{
    public class HeatIndexDisplay : IObserver, IDisplayElement
    {
        private float _heatIndex;
        private IWeatherData weatherData;
        private WeatherDataObject _dataObject;

        public HeatIndexDisplay(IWeatherData wd)
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
            this._heatIndex = ComputeHeatIndex(_dataObject.temp, _dataObject.humidity);
            Debug.WriteLine("==Heat Index==");
            Debug.WriteLine("Actual feeling: " + _heatIndex);
        }

        private float ComputeHeatIndex(float temp, float humidity)
        {
            float index = (float)((16.923 + (0.185212 * temp) + (5.37941 * humidity) - (0.100254 * temp * humidity) +
                                    (0.00941695 * (temp * temp)) + (0.00728898 * (humidity * humidity)) +
                                    (0.000345372 * (temp * temp * humidity)) - (0.000814971 * (temp * humidity * humidity)) +
                                    (0.0000102102 * (temp * temp * humidity * humidity)) - (0.000038646 * (temp * temp * temp)) + (0.0000291583 *
                                                                                                        (humidity * humidity * humidity)
                                    ) + (0.00000142721 * (temp * temp * temp * humidity)) +
                                    (0.000000197483 * (temp * humidity * humidity * humidity)) - (0.0000000218429 * (temp * temp * temp * humidity * humidity)) +
                                    0.000000000843296 * (temp * temp * humidity * humidity * humidity)) -
                                   (0.0000000000481975 * (temp * temp * temp * humidity * humidity * humidity)));
            return index;
        }
    }
}
