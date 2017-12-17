using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._01_Strategy
{
    public abstract class Duck
    {
        public void Quack()
        {
            Console.WriteLine("Generic quack behavior");
        }

        public void Swim()
        {
            Console.WriteLine("Generic swimming behavior..");
        }

        public void Fly()
        {
            Console.WriteLine("Generic flying ability");
        }

        public abstract void Display();


    }
}
