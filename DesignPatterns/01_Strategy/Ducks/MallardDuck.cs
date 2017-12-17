using System;
using DesignPatterns._01_Strategy.Behavior;

namespace DesignPatterns._01_Strategy.Ducks
{
    public class MallardDuck : Duck
    {

        public MallardDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new QuackNormal();
        }
        public override void Display()
        {
            Console.WriteLine("Drawing a Mallard duck on screen..");
        }


    }
}
