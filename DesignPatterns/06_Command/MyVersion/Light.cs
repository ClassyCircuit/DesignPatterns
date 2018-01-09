using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._06_Command.MyVersion
{
    public class Light
    {
        public void SwitchOn()
        {
            Console.WriteLine("Lights are on");
        }
        public void SwitchOff()
        {
            Console.WriteLine("Lights are off");
        }
    }
}
