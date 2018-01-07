using System;
using DesignPatterns._04_Factory.AbstractFactory.BaseProducts;
using DesignPatterns._04_Factory.AbstractFactory.NYStyle.Products;

namespace DesignPatterns._04_Factory.AbstractFactory.NYStyle.PizzaStore
{
    public class NYStylePizzaStore : AbstractFactory.PizzaStore.PizzaStore
    {
        protected override Pizza CreatePizza(string type, Enum size)
        {
            Pizza pizza = null;

            if (type.Equals("greek"))
            {
                pizza = new NYStyleGreekPizza(size);
            }
            else if (type.Equals("cheese"))
            {
                pizza = new NYStyleCheesePizza(size);
            }
            else
            {
                throw new ArgumentException();
            }

            return pizza;
        }


    }
}
