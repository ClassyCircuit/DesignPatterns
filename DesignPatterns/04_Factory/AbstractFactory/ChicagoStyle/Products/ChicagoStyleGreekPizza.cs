using System;
using System.Collections.Generic;
using DesignPatterns._04_Factory.AbstractFactory.BaseProducts;

namespace DesignPatterns._04_Factory.AbstractFactory.ChicagoStyle.Products
{
    class ChicagoStyleGreekPizza : Pizza
    {
        public ChicagoStyleGreekPizza(Enum size)
        {
            this.Name = "ChicagoStyle greek";
            this.Price = 25.85m;
            this.Size = size;
            this.Sauce = "Hot sauce";
            this.Toppings = new List<string>()
            {
                "Grated soft cheese", "Blue carribean cheese", "Chili"
            };
        }

        public override void Cut()
        {
            Console.WriteLine($"Cutting {Name} pizza only in half");
        }
    }
}
