using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._01_Strategy
{
    class MallardDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("Drawing a Mallard duck on screen..");
        }
    }
}
