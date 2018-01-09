using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._06_Command.HomeAutomation.Commands
{
    public class NoCommand : ICommand
    {
        // Empty command that does nothing
        public void Execute () { }
    }
}
