using System;
using System.Collections.Generic;
using DesignPatterns._04_Factory.AbstractFactory.BaseProducts;

namespace DesignPatterns._04_Factory.AbstractFactory.ChicagoStyle.Products
{
    class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza(Enum size)
        {
            this.Name = "ChicagoStyle cheese";
            this.Price = 17.50m;
            this.Size = size;
            this.Sauce = "Red cherry sauce";
            this.Toppings = new List<string>()
            {
                "pickles", "cherry"
            };
        }

        public override void Bake()
        {
            Console.WriteLine($"Baking {Name} pizza at 385 degrees");
        }


    }
}
