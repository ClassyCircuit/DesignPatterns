using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03_Decorator.CoffeeShop
{
    public class SteamedMilk : CondimentDecorator, IBeverage
    {
        public override string Description => DecoratedBeverage.Description + ", Steamed Milk";

        private decimal _cost { get; set; }
        public override decimal Cost
        {
            get
            {
                _cost = DecoratedBeverage.Cost;
                if (DecoratedBeverage.Size is (BeverageSize.Large))
                {
                    _cost += 1.5m;
                }
                else if (DecoratedBeverage.Size is (BeverageSize.Medium))
                {
                    _cost += 1.00m;
                }
                else if (DecoratedBeverage.Size is (BeverageSize.Small))
                {
                    _cost += 0.5m;
                }

                return _cost;

            }
            
        }

        public SteamedMilk(IBeverage beverage)
        {
            DecoratedBeverage = beverage;
        }
    }
}
