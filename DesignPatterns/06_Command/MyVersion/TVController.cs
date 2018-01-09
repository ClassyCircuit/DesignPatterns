using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._06_Command.MyVersion
{
    public class TVController : IController
    {
        private TV _tv = new TV();

        public void On()
        {
            _tv.TurnOn();
        }

        public void Off()
        {
            _tv.TurnOff();
        }
    }
}
