using System;
using System.Collections.Generic;
using DesignPatterns._04_Factory.AbstractFactory.BaseProducts;

namespace DesignPatterns._04_Factory.AbstractFactory.NYStyle.Products
{
    public class NYStyleGreekPizza : Pizza
    {
        private IPizzaIngredientFactory _ingredientFactory;

        public NYStyleGreekPizza(Enum size, IPizzaIngredientFactory ingredientFactory)
        {
            this._ingredientFactory = ingredientFactory;
            this.Name = "NYStyle greek";
            this.Price = 35.85m;
            this.Size = size;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            this.cheese = _ingredientFactory.CreateCheese();
            this.clams = _ingredientFactory.CreateClams();
            this.sauce = _ingredientFactory.CreateSauce();
        }

        public override void Bake()
        {
            Console.WriteLine($"Baking NYStyle {Name} pizza at 200 degrees");
        }
    }
}
