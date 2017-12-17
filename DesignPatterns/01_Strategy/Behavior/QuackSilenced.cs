using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._01_Strategy.Behavior
{
    class QuackSilenced : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("This duck can't quack..");
        }
    }
}
