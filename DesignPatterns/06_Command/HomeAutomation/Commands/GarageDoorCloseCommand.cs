using DesignPatterns._06_Command.HomeAutomation.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._06_Command.HomeAutomation.Commands
{
    public class GarageDoorCloseCommand : ICommand
    {
        private GarageDoor _door;
        public GarageDoorCloseCommand(GarageDoor door)
        {
            _door = door;
        }
        public void Execute()
        {
            _door.Down();
        }

        public void Undo()
        {
            _door.Up();
        }
    }
}
