using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03_Decorator.CoffeeShop
{
    public class Mocha : IBeverage
    {
        public string Description { get; }
        private decimal _cost { get; set; }
        private IBeverage DecoratedBeverage { get; set; }
        public decimal Cost => _cost + DecoratedBeverage.Cost;

        public Mocha(IBeverage beverage)
        {
            Description = "Mocha condiment";
            _cost = 0.75m;
            DecoratedBeverage = beverage;
        }

        
    }



}
