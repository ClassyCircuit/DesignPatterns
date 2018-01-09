using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._06_Command.MyVersion
{
    public class HotTub
    {
        public void Enable()
        {
            Console.WriteLine("HotTub enabled");
        }

        public void Disable()
        {
            Console.WriteLine("HotTub disabled");
        }
    }
}
