using System;
using DesignPatterns._01_Strategy.Behavior;

namespace DesignPatterns._01_Strategy.Ducks
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            this.FlyBehavior = new FlyNoWay();
            this.QuackBehavior = new QuackSilenced();
        }
        public override void Display()
        {
            Console.WriteLine("Drawing a decoy duck..");
        }


    }
}
