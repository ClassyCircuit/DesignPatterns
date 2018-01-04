using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03_Decorator.CoffeeShop
{
    public class Espresso : IBeverage
    {
        public string Description { get; }
        public decimal Cost { get; }
        public Enum Size { get; set; }

        public Espresso(Enum size)
        {
            Description = "Espresso";
            Cost = 3.33m;
            Size = size;
        }
    }
}
