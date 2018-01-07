using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03_Decorator.CoffeeShop
{
    public class Whip : CondimentDecorator
    {
        public override string Description => DecoratedBeverage.Description + ", Whip";
        private decimal _cost { get; set; }

        public override decimal Cost
        {
            get
            {
                _cost = DecoratedBeverage.Cost;
                if (DecoratedBeverage.Size is (BeverageSize.Large))
                {
                    _cost += 0.7m;
                }
                else if (DecoratedBeverage.Size is (BeverageSize.Medium))
                {
                    _cost += 0.5m;
                }
                else if (DecoratedBeverage.Size is (BeverageSize.Small))
                {
                    _cost += 0.2m;
                }

                return _cost;

            }
            
        }
        
        public Whip(IBeverage beverage)
        {
            DecoratedBeverage = beverage;    
        }
    }
}

