using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._06_Command.HomeAutomation.Receivers
{
    public class GarageDoor
    {
        private bool _doorState = false;

        public void Up()
        {
            _doorState = true;
            Console.WriteLine("Garage door is opening..");
        }

        public void Down()
        {
            _doorState = false;
            Console.WriteLine("Garage door is closing..");
        }
    }
}
