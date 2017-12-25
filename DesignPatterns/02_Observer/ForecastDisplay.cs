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

        private float _pressure;
        private float _lastPressure = 0.00f;
        public void Update(float humidity, float temp, float pressure)
        {
            this._lastPressure = _pressure;
            this._pressure = pressure;
            Display();
        }

        public void Display()
        {
            Debug.WriteLine("==Forecast==");
            if (_pressure > _lastPressure)
            {
            Debug.WriteLine("Weather is going to improve!");
            }else if (_pressure == _lastPressure)
            {
                Debug.WriteLine("Same weather ahead!");
            }else if (_pressure < _lastPressure)
            {
                Debug.WriteLine("Weather is going to get worse!");
            }
          
        }
    }
}
