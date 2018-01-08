using System;
using System.Collections.Generic;
using DesignPatterns._04_Factory.AbstractFactory.BaseProducts;

namespace DesignPatterns._04_Factory.AbstractFactory.ChicagoStyle.Products
{
    class ChicagoStyleGreekPizza : Pizza
    {
        private IPizzaIngredientFactory _ingredientFactory;
        public ChicagoStyleGreekPizza(Enum size, IPizzaIngredientFactory ingredientFactory)
        {
            this.Name = "ChicagoStyle greek";
            this.Price = 25.85m;
            this.Size = size;
            this._ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            this.cheese = _ingredientFactory.CreateCheese();
            this.dough = _ingredientFactory.CreateDough();
            this.sauce = _ingredientFactory.CreateSauce();
            this.pepperoni = _ingredientFactory.CreatePepperoni();
        }

        public override void Cut()
        {
            Console.WriteLine($"Cutting {Name} pizza only in half");
        }
    }
}
