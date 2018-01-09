using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._06_Command.MyVersion
{
    public class LightController : IController
    {
        private Light _light = new Light();
        public void On()
        {
            _light.SwitchOn();
        }
        public void Off()
        {
            _light.SwitchOff();
        }
    }
}
