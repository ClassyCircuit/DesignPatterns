using System;
using DesignPatterns._04_Factory.AbstractFactory.BaseProducts;
using DesignPatterns._04_Factory.AbstractFactory.ChicagoStyle.Ingredients;
using DesignPatterns._04_Factory.AbstractFactory.ChicagoStyle.Products;

namespace DesignPatterns._04_Factory.AbstractFactory.ChicagoStyle.PizzaStore
{
    public class ChicagoStylePizzaStore : AbstractFactory.PizzaStore.PizzaStore
    {
        

        protected override Pizza CreatePizza(string type, Enum size)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory _ingredientFactory = new ChicagoPizzaIngredientFactory();

            if (type.Equals("greek"))
            {
                pizza = new ChicagoStyleGreekPizza(size, _ingredientFactory);
            }
            else if (type.Equals("cheese"))
            {
                pizza = new ChicagoStyleCheesePizza(size, _ingredientFactory);
            }
            else
            {
                throw new ArgumentException();
            }

            return pizza;
        }
    }
}
