using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._06_Command.MyVersion
{
    public class Stereo
    {
        public void SetOn()
        {
            Console.WriteLine("Stereo is set on");
        }

        public void SetOff()
        {
            Console.WriteLine("Stereo is set off");
        }
    }
}
