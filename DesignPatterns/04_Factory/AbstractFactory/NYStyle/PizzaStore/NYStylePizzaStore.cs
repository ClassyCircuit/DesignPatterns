using System;
using DesignPatterns._04_Factory.AbstractFactory.BaseProducts;
using DesignPatterns._04_Factory.AbstractFactory.NYStyle.Ingredients;
using DesignPatterns._04_Factory.AbstractFactory.NYStyle.Products;

namespace DesignPatterns._04_Factory.AbstractFactory.NYStyle.PizzaStore
{
    public class NYStylePizzaStore : AbstractFactory.PizzaStore.PizzaStore
    {
        protected override Pizza CreatePizza(string type, Enum size)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory pizzaIngredientFactory = new NYPizzaIngredientFactory();

            if (type.Equals("greek"))
            {
                pizza = new NYStyleGreekPizza(size, pizzaIngredientFactory);
            }
            else if (type.Equals("cheese"))
            {
                pizza = new NYStyleCheesePizza(size, pizzaIngredientFactory);
            }
            else
            {
                throw new ArgumentException();
            }

            return pizza;
        }


    }
}
