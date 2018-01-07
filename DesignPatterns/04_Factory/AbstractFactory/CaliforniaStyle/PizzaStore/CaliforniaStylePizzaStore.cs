using System;
using DesignPatterns._04_Factory.AbstractFactory.BaseProducts;
using DesignPatterns._04_Factory.AbstractFactory.CaliforniaStyle.Products;

namespace DesignPatterns._04_Factory.AbstractFactory.CaliforniaStyle.PizzaStore
{
    public class CaliforniaStylePizzaStore : AbstractFactory.PizzaStore.PizzaStore
    {
        protected override Pizza CreatePizza(string type, Enum size)
        {
            Pizza pizza = null;

            if (type.Equals("greek"))
            {
                pizza = new CaliforniaStyleGreekPizza(size);
            }
            else if (type.Equals("cheese"))
            {
                pizza = new CaliforniaStyleCheesePizza(size);
            }
            else
            {
                throw new ArgumentException();
            }

            return pizza;
        }
    }
}
