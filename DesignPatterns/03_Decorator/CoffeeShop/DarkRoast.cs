using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03_Decorator.CoffeeShop
{
    public class DarkRoast : IBeverage
    {
        public string Description { get; }
        public decimal Cost { get; }

        public DarkRoast()
        {
            Description = "Most Excellent Dark Roast!";
            Cost = 1.60m;
        }

    }
}
