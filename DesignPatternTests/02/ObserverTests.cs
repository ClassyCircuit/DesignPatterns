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
            IObserver fd = new ForecastDisplay();
            IObserver sd = new StatisticsDisplay();
            IObserver ccd = new CurrentConditionsDisplay();

            WeatherData wd = new WeatherData();
            wd.RegisterObserver(fd);
            wd.RegisterObserver(sd);
            wd.RegisterObserver(ccd);

            wd.MeasurementsChanged();

        }
    }
}
