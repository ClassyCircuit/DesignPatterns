using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._06_Command.MyVersion
{
    public class Remote
    {
        // This is my interpretation how to implement the remote from book.
        // It was created before I learned about command pattern.
        private int ButtonAmount;
        private RemoteController _controller;

        public Remote()
        {
            ButtonAmount = 7;
            _controller = new RemoteController();
        }

        public void TurnDeviceOn(int remoteButtonId)
        {
            if (remoteButtonId > 0 && remoteButtonId <= ButtonAmount)
            {
                _controller.TurnDeviceOn(remoteButtonId);
            }
        }
        public void TurnDeviceOff(int remoteButtonid)
        {
            if (remoteButtonid > 0 && remoteButtonid <= ButtonAmount)
            {
                _controller.TurnDeviceOff(remoteButtonid);
            }
        }
    }
}
