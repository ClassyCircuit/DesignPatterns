using System;
using DesignPatterns._04_Factory.AbstractFactory.BaseProducts;

namespace DesignPatterns._04_Factory.AbstractFactory.PizzaStore
{
    public abstract class PizzaStore
    {

        public Pizza OrderPizza(string type, Enum size)
        {
            Pizza pizza = CreatePizza(type, size);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(string type, Enum size);
    }
}
