using System;
using System.Collections.Generic;
using DesignPatterns._04_Factory.AbstractFactory.BaseProducts;

namespace DesignPatterns._04_Factory.AbstractFactory.ChicagoStyle.Products
{
    class ChicagoStyleCheesePizza : Pizza
    {
        private IPizzaIngredientFactory _ingredientFactory;
        public ChicagoStyleCheesePizza(Enum size, IPizzaIngredientFactory ingredientFactory)
        {
            this.Name = "ChicagoStyle cheese";
            this.Price = 17.50m;
            this.Size = size;
            this._ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            this.dough = _ingredientFactory.CreateDough();
            this.sauce = _ingredientFactory.CreateSauce();
            this.cheese = _ingredientFactory.CreateCheese();
        }

        public override void Bake()
        {
            Console.WriteLine($"Baking {Name} pizza at 385 degrees");
        }


    }
}
