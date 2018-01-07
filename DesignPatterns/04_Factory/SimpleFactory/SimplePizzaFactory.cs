using System;

namespace DesignPatterns._04_Factory.SimpleFactory
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type, Enum size)
        {
            Pizza pizza = null;

            if (type.Equals("greek"))
            {
                pizza = new GreekPizza(size);
            }
            else if (type.Equals("cheese"))
            {
                pizza = new CheesePizza(size);
            }
            else
            {
                throw new ArgumentException();
            }

            return pizza;
        }
    }
}
