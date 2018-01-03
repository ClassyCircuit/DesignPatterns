using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns._03_Decorator.CoffeeShop;

namespace DesignPatternTests._03
{
    [TestClass]
    public class CoffeeShopTest
    {
        [TestMethod]
        public void DarkRoastMochaWithWhip()
        {
            IBeverage roast = new DarkRoast();
            IBeverage mocha = new Mocha(roast);
            IBeverage whip = new Whip(mocha);


            Debug.WriteLine(whip.Cost);
        }
    }
}
