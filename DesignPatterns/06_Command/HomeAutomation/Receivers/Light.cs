using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._06_Command.HomeAutomation.Receivers
{
    public class Light
    {
        private bool _state = false;
        private string Name;

        public Light(string name)
        {
            Name = name;
        }

        public void On()
        {
            _state = true;
            Console.WriteLine($"{Name} turned on");
        }

        public void Off()
        {
            _state = false;
            Console.WriteLine($"{Name} turned off");
        }
    }
}
