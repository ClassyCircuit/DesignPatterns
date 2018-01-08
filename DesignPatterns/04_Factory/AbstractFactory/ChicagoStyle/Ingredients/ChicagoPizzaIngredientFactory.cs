using DesignPatterns._04_Factory.AbstractFactory.BaseProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._04_Factory.AbstractFactory.ChicagoStyle.Ingredients
{
    class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new HeavyDough();
        }

        public Sauce CreateSauce()
        {
            return new MushroomSauce();
        }

        public Cheese CreateCheese()
        {
            return new SoftCheese();
        }

        public Veggies[] CreateVeggies()
        {
            Veggies[] veggies = { new BlackOlives(), new Pickles() };
            return veggies;
        }

        public Pepperoni CreatePepperoni()
        {
            return new HotPepperoni();
        }

        public Clams CreateClams()
        {
            return new FrozenClams();
        }
    }
}
