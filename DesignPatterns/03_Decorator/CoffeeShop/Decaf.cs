using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03_Decorator.CoffeeShop
{
    public class Decaf : IBeverage
    {
        public string Description { get; }
        public decimal Cost { get; }
        public Enum Size { get; set; }

        public Decaf(Enum size)
        {
            Description = Size + " Decaf";
            Cost = 1.99m;
            Size = size;
        }
    }
}
