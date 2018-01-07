using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns._04_Factory.SimpleFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternTests._04
{
    [TestClass]
    public class SimplePizzaStoreTests
    {
        [TestMethod]
        public void CreateGreekPizza()
        {
            SimplePizzaFactory simplePizzaFactory = new SimplePizzaFactory();
            PizzaStore store = new PizzaStore(simplePizzaFactory);
            Pizza greekPizza = store.OrderPizza("greek", Size.Medium);

            Assert.AreEqual("greek", greekPizza.Name);
            Assert.AreEqual(Size.Medium, greekPizza.Size);
        }

        [TestMethod]
        public void CreateCheesePizza()
        {
            SimplePizzaFactory simplePizzaFactory = new SimplePizzaFactory();
            PizzaStore store = new PizzaStore(simplePizzaFactory);
            Pizza cheesePizza = store.OrderPizza("cheese", Size.Large);

            Assert.AreEqual("cheese", cheesePizza.Name);
            Assert.AreEqual(Size.Large, cheesePizza.Size);
        }
    }
}
