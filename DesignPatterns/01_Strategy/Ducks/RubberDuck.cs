using System;
using DesignPatterns._01_Strategy.Behavior;

namespace DesignPatterns._01_Strategy.Ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            this.FlyBehavior = new FlyNoWay();
            this.QuackBehavior = new QuackSilenced();
        }

        public override void Display()
        {
            Console.WriteLine("drawing a rubber duck..");
        }


        
    }
}
