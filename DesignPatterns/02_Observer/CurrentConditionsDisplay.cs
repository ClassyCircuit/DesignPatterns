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
        private float _temp;
        private float _humidity;
        public void Update(float humidity, float temp, float pressure)
        {
            this._humidity = humidity;
            this._temp = temp;
            Display();
        }

        public void Display()
        {
            Debug.WriteLine("==Current conditions==");
            Debug.WriteLine("Temp: " + _temp);
            Debug.WriteLine("Humidity: " + _humidity);
        }
    }
}
