using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._01_Strategy.Behavior
{
    public class FlyWithRockets : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Flying with a rocket..");
        }

        public void Land()
        {
            Console.WriteLine("Landing with a rocket..");
        }
    }
}
