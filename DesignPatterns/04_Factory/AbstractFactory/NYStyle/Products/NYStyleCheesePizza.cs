using System;
using System.Collections.Generic;
using DesignPatterns._04_Factory.AbstractFactory.BaseProducts;

namespace DesignPatterns._04_Factory.AbstractFactory.NYStyle.Products
{
    public class NYStyleCheesePizza : Pizza
    {
        private IPizzaIngredientFactory _ingredientFactory;

        public NYStyleCheesePizza(Enum size, IPizzaIngredientFactory ingredientFactory)
        {
            this._ingredientFactory = ingredientFactory;
            this.Name = "NYStyle cheese";
            this.Price = 8.99m;
            this.Size = size;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            this.dough = _ingredientFactory.CreateDough();
            this.sauce = _ingredientFactory.CreateSauce();
            this.cheese = _ingredientFactory.CreateCheese();
        }
 
    }
}
