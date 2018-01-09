using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._06_Command.MyVersion
{
    public class RemoteController
    {
        private List<IController> config = new List<IController>()
        {
            new StereoController(),
            new TVController(),
            new HotTubController(),
            new LightController()
        };

        public void TurnDeviceOn(int remoteButtonId)
        {
            config[remoteButtonId - 1].On();
        }

        public void TurnDeviceOff(int remoteButtonId)
        {
            config[remoteButtonId - 1].Off();
        }
    }
}
