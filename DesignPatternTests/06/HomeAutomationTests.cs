using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns._06_Command.HomeAutomation;
using DesignPatterns._06_Command.HomeAutomation.Receivers;
using DesignPatterns._06_Command.HomeAutomation.Commands;

namespace DesignPatternTests._06
{
    [TestClass]
    public class HomeAutomationTests
    {
        private Remote remote;

        [TestInitialize]
        public void InitializeCommandTests()
        {
            // receivers
            Light kitchenLight = new Light("kitchen light");
            Light bedroomLight = new Light("bedroom light");
            GarageDoor garageDoor = new GarageDoor();

            // commands
            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);
            LightOnCommand bedroomLightOn = new LightOnCommand(bedroomLight);
            LightOffCommand bedroomLightOff = new LightOffCommand(bedroomLight);
            GarageDoorOpenCommand garageOpenCmd = new GarageDoorOpenCommand(garageDoor);
            GarageDoorCloseCommand garageCloseCmd = new GarageDoorCloseCommand(garageDoor);

            // assign commands to remote
            this.remote = new Remote();
            remote.SetCommand(0, kitchenLightOn, kitchenLightOff);
            remote.SetCommand(1, bedroomLightOn, bedroomLightOff);
            remote.SetCommand(2, garageOpenCmd, garageCloseCmd);

            Console.WriteLine(remote.ToString());
        }

        [TestMethod]
        public void TurnAllLightsOnTest()
        {
            remote.PressOnButton(0);
            remote.PressOnButton(1);
        }

        [TestMethod]
        public void TurnAllLightsOffTest()
        {
            remote.PressOffButton(0);
            remote.PressOffButton(1);
        }

        [TestMethod]
        public void UndoTurningLightsOn()
        {
            remote.PressOnButton(0);
            remote.PressUndoButton();
        }

        [TestMethod]
        public void PressUndoButtonRightAway()
        {
            remote.PressUndoButton();
        }
    }


}
