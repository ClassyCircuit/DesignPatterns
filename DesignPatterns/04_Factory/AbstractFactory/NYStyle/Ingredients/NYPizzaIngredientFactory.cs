using DesignPatterns._04_Factory.AbstractFactory.BaseProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._04_Factory.AbstractFactory.NYStyle.Ingredients
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public ICheese CreateCheese()
        {
            return new ReggyCheese();
        }

        public Veggies[] CreateVeggies()
        {
            Veggies[] veggies = {new Onion(), new Garlic() };
            return veggies;
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Clams CreateClams()
        {
            return new FreshClams();
        }
    }
}
