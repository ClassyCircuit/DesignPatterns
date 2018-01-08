using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._05_Singleton
{
    // Eagerly created singleton consumes low amount of resources.
    // Recommended approach in most cases.
    public class EagerSingleton
    {
        private static EagerSingleton _uniqueInstance = new EagerSingleton();

        private EagerSingleton(){}

        public static EagerSingleton GetInstance()
        {
            return _uniqueInstance;
        }
    }
}
