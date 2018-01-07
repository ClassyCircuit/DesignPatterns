using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03_Decorator.CoffeeShop
{
    public class Mocha : CondimentDecorator
    {
        public override string Description
        {
            get { return DecoratedBeverage.Description + ", Mocha"; }
        }

        private decimal _cost { get; set; }
        public override decimal Cost
        {
            get
            {
                _cost = DecoratedBeverage.Cost;
                if (DecoratedBeverage.Size is (BeverageSize.Large))
                {
                    _cost += 5.13m;
                }
                else if (DecoratedBeverage.Size is (BeverageSize.Medium))
                {
                    _cost += 3.81m;
                }
                else if (DecoratedBeverage.Size is (BeverageSize.Small))
                {
                    _cost += 1.85m;
                }

                return _cost;

            }
            
        }

        public Mocha(IBeverage beverage)
        {
            DecoratedBeverage = beverage;
        }     
    }
}
