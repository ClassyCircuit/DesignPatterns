using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02_Observer
{
    public class WeatherDataObject
    {
        public float temp { get; set; }
        public float humidity { get; set; }
        public float pressure { get; set; }


        public WeatherDataObject()
        {
            this.temp = 0;
            this.humidity = 0;
            this.pressure = 0;
        }

    }
}
