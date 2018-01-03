using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03_Decorator.CoffeeShop
{
    public class Whip : IBeverage
    {
        public string Description { get; }
        private decimal _cost { get; set; }
        private IBeverage DecoratedBeverage { get; set; }
        public decimal Cost => _cost + DecoratedBeverage.Cost;

        public Whip(IBeverage beverage)
        {
            Description = "Whip condiment";
            _cost = 0.45m;
            DecoratedBeverage = beverage;

        }
    }
}
