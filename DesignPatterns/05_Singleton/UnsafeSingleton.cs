using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._05_Singleton
{
    public class UnsafeSingleton
    {
        private static UnsafeSingleton _instance = null;

        private UnsafeSingleton()
        {
            
        }

        public static UnsafeSingleton GetSingleton()
        {
            if (_instance == null)
            {
                _instance = new UnsafeSingleton();
            }
            return _instance;
        }
    }
}
