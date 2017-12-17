using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns._01_Strategy.Behavior;

namespace DesignPatterns._01_Strategy
{
    public abstract class Duck
    {
        public IFlyBehavior FlyBehavior { get; set; }
        public IQuackBehavior QuackBehavior { get; set; }
        

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("Generic swimming behavior..");
        }

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformLand()
        {
            FlyBehavior.Land();
        }

        public abstract void Display();

    }
}
