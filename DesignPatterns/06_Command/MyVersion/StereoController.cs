using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._06_Command.MyVersion
{
    public class StereoController : IController
    {
        private Stereo _stereo = new Stereo();
        public StereoController()
        {
            
        }
        public void On()
        {
            _stereo.SetOn();
        }

        public void Off()
        {
            _stereo.SetOff();
        }
    }
}
