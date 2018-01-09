using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns._06_Command.MyVersion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternTests._06
{
    [TestClass]
    public class MyVersionTests
    {
        [TestMethod]
        public void TurnFirstDeviceOn()
        {
            Remote remote = new Remote();
            remote.TurnDeviceOn(1);
        }

        [TestMethod]
        public void TurnFirstDeviceOff()
        {
            Remote remote = new Remote();
            remote.TurnDeviceOff(1);
        }

    }
}
