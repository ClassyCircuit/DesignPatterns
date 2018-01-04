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
        public Enum Size { get; set; }

        public HouseBlend(Enum size)
        {
            Description = Size + " Excellent House Blend";
            Cost = 2.55m;
            Size = size;
        }
        
    }

    
}
