using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._06_Command.MyVersion
{
    public class HotTubController : IController
    {
        private HotTub _tub = new HotTub();

        public void On()
        {
            _tub.Enable();
        }
        public void Off()
        {
            _tub.Disable();
        }
    }
}
