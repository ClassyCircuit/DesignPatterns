using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns._01_Strategy.Behavior;

namespace DesignPatterns._01_Strategy.Ducks
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            this.FlyBehavior = new FlyNoWay();
            this.QuackBehavior = new QuackSilenced();
        }
        public override void Display()
        {
            Console.WriteLine("Drawing a model duck..");
        }
    }
}
