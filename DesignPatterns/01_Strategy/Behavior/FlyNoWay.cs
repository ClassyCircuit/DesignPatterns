using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._01_Strategy.Behavior
{
    class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("This duck can't fly..");
        }

        public void Land()
        {
            Console.WriteLine("This duck can't land..");
        }
    }
}
