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
    public class CoffeeShopTests
    {
        [TestMethod]
        public void DarkRoastMochaWithWhip()
        {
            IBeverage roast = new DarkRoast(BeverageSize.Large);
            roast = new Mocha(roast);
            roast = new Whip(roast);

            Debug.WriteLine(roast.Description);
            Debug.WriteLine("Cost: " + roast.Cost);
        }

        [TestMethod]
        public void DoubleMochaSoyLatteWithWhip()
        {
            IBeverage houseBlend = new HouseBlend(BeverageSize.Medium);
            houseBlend = new Soy(houseBlend);
            houseBlend = new Whip(houseBlend);
            houseBlend = new Mocha(houseBlend);
            houseBlend = new Mocha(houseBlend);

            Debug.WriteLine(houseBlend.Description);
            Debug.WriteLine("Cost: " + houseBlend.Cost);
        
        }

        [TestMethod]
        public void HouseBlendSoyMochaWhip()
        {
            IBeverage houseBlend = new HouseBlend(BeverageSize.Small);
            houseBlend = new Soy(houseBlend);
            houseBlend = new Whip(houseBlend);
            houseBlend = new Mocha(houseBlend);

            Debug.WriteLine(houseBlend.Description);
            Debug.WriteLine("Cost: " + houseBlend.Cost);
        }
    }
}

