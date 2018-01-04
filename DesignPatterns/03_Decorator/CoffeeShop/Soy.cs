using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03_Decorator.CoffeeShop
{
    public class Soy : CondimentDecorator
    {
        public override string Description => DecoratedBeverage.Description + ", Soy";

        private decimal _cost { get; set; }
        public override decimal Cost
        {
            get
            {
                _cost = DecoratedBeverage.Cost;
                if (DecoratedBeverage.Size.Equals(BeverageSize.Large))
                {
                    _cost += 2.1m;
                }
                else if (DecoratedBeverage.Size.Equals(BeverageSize.Medium))
                {
                    _cost += 1.8m;
                }
                else if (DecoratedBeverage.Size.Equals(BeverageSize.Small))
                {
                    _cost += 1.2m;
                }

                return _cost;

            }
            
        }

        public Soy(IBeverage beverage)
        {

            DecoratedBeverage = beverage;
        }
    }
}
