using System;

namespace DesignPatterns._04_Factory.SimpleFactory
{
    public class PizzaStore
    {
        private SimplePizzaFactory Factory { get; set; }

        public PizzaStore(SimplePizzaFactory factory)
        {
            this.Factory = factory;
        }

        public Pizza OrderPizza(string type, Enum size)
        {
            Pizza pizza = Factory.CreatePizza(type, size);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
