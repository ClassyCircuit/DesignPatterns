using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03_Decorator.CoffeeShop
{
    public abstract class CondimentDecorator : IBeverage
    {
        protected IBeverage DecoratedBeverage { get; set; }

        public abstract string Description { get; }
        public abstract decimal Cost { get; }
        public Enum Size { get; set; }
    }
}
