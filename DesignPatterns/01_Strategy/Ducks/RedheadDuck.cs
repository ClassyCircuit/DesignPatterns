using System;
using DesignPatterns._01_Strategy.Behavior;

namespace DesignPatterns._01_Strategy.Ducks
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            this.FlyBehavior = new FlyWithWings();
            this.QuackBehavior = new QuackNormal();
        }

        public override void Display()
        {
            Console.WriteLine("Drawing a Readhead duck on screen..");
        }
    }
}
