using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._06_Command.MyVersion
{
    public interface IController
    {
        // Common interface that device controllers have to implement
        void On();
        void Off();
    }
}
