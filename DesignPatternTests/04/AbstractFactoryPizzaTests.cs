using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns._04_Factory.AbstractFactory.NYStyle.PizzaStore;
using DesignPatterns._04_Factory.AbstractFactory.ChicagoStyle.PizzaStore;
using DesignPatterns._04_Factory.SimpleFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizza = DesignPatterns._04_Factory.AbstractFactory.BaseProducts.Pizza;
using PizzaStore = DesignPatterns._04_Factory.AbstractFactory.PizzaStore.PizzaStore;

namespace DesignPatternTests._04
{
    [TestClass]
    public class AbstractFactoryPizzaTests
    {
        [TestMethod]
        public void CreateNYStyleCheesePizza()
        {
            PizzaStore NYStore = new NYStylePizzaStore();
            Pizza pizza = NYStore.OrderPizza("cheese", Size.Large);
            Assert.AreEqual("NYStyle cheese", pizza.Name);
            Assert.AreEqual(Size.Large, pizza.Size);
        }

        [TestMethod]
        public void CreateChicagoStyleCheesePizza()
        {
            PizzaStore chicagoStore = new ChicagoStylePizzaStore();
            Pizza pizza = chicagoStore.OrderPizza("cheese", Size.Large);
            Assert.AreEqual("ChicagoStyle cheese", pizza.Name);
            Assert.AreEqual(Size.Large, pizza.Size);
        }
    }
}
