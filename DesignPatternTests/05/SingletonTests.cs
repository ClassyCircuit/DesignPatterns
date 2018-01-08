using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns._05_Singleton;

namespace DesignPatternTests._05
{
    [TestClass]
    public class SingletonTests
    {
        [TestMethod]
        public void GetUnsafeSingleton()
        {
            // Unsafe singleton means that it can be created twice, if 2+ threads access the creation method at nearly the same time.

            UnsafeSingleton unsafeSingleton = UnsafeSingleton.GetSingleton();
            Assert.IsInstanceOfType(unsafeSingleton, typeof(UnsafeSingleton));
        }

        [TestMethod]
        public void GetEagerSingleton()
        {
            // Locks the creation of object to 1 thread, but is very expensive.

            EagerSingleton eagerSingleton = EagerSingleton.GetInstance();
            Assert.IsInstanceOfType(eagerSingleton, typeof(EagerSingleton));
        }
    }    
}
