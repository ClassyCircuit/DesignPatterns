using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._06_Command.MyVersion
{
    public class TV
    {
        public void TurnOn()
        {
            Console.WriteLine("TV is turned on");
        }
        public void TurnOff()
        {
            Console.WriteLine("TV is turned off");
        }
    }
}
