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
            IBeverage roast = new DarkRoast(BeverageSize.Large);
            IBeverage mocha = new Mocha(roast);
            IBeverage whip = new Whip(mocha);

            Debug.WriteLine(whip.Description);
            Debug.WriteLine("Cost: " + whip.Cost);
        }

        [TestMethod]
        public void DoubleMochaSoyLatteWithWhip()
        {
            IBeverage houseBlend = new HouseBlend(BeverageSize.Medium);
            IBeverage soy = new Soy(houseBlend);
            IBeverage whip = new Whip(soy);
            IBeverage mocha1 = new Mocha(whip);
            IBeverage mocha2 = new Mocha(mocha1);

            Debug.WriteLine(mocha2.Description);
            Debug.WriteLine("Cost: " + mocha2.Cost);
        
        }
    }
}
