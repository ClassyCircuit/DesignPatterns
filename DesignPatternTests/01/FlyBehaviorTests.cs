using System;
using DesignPatterns._01_Strategy.Behavior;
using DesignPatterns._01_Strategy.Ducks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternTests._01
{
    [TestClass]
    public class FlyBehaviorTests
    {
        [TestMethod]
        public void DucksWithWingsCanFly()
        {
            MallardDuck md = new MallardDuck();
            md.PerformFly();
        }

        [TestMethod]
        public void DucksWithWingsCanLand()
        {
            MallardDuck md = new MallardDuck();
            md.PerformLand();
        }

        [TestMethod]
        public void FakeDucksCantFly()
        {
            RubberDuck rd = new RubberDuck();
            DecoyDuck dd = new DecoyDuck();
            rd.PerformFly();
            dd.PerformFly();
        }

        [TestMethod]
        public void FakeDucksCantLand()
        {
            RubberDuck rd = new RubberDuck();
            DecoyDuck dd = new DecoyDuck();
            rd.PerformLand();
            dd.PerformLand();
        }

        [TestMethod]
        public void DucksCanChangeFlyBehavior()
        {
            ModelDuck md = new ModelDuck();
            md.PerformFly();
            md.PerformLand();

            md.FlyBehavior = new FlyWithRockets();
            md.PerformFly();
            md.PerformLand();
        }


    }
}
