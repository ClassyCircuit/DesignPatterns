using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03_Decorator.CoffeeShop
{
    public class HouseBlend : IBeverage
    {
        public string Description { get; }
        public decimal Cost { get;  }

        public HouseBlend()
        {
            Description = "Excellent House Blend";
            Cost = 2.55m;
        }

    }
}
