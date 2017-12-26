using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns._02_Observer;

namespace DesignPatternTests._02
{
    [TestClass]
    public class ObserverTests
    {
        [TestMethod]
        public void UpdateObservers()
        {
            WeatherData wd = new WeatherData();

            IObserver fd = new ForecastDisplay(wd);
            IObserver sd = new StatisticsDisplay(wd);
            IObserver ccd = new CurrentConditionsDisplay(wd);
            IObserver hi = new HeatIndexDisplay(wd);

            wd.SetMeasurements(5.5f, 200f, 0.05f);

        }
    }
}
