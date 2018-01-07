using System;
using System.Collections.Generic;
using DesignPatterns._04_Factory.AbstractFactory.BaseProducts;

namespace DesignPatterns._04_Factory.AbstractFactory.NYStyle.Products
{
    public class NYStyleGreekPizza : Pizza
    {

        public NYStyleGreekPizza(Enum size)
        {
            this.Name = "NYStyle greek";
            this.Price = 35.85m;
            this.Size = size;
            this.Sauce = "Cucumber sauce";
            this.Toppings = new List<string>()
            {
                "Blue cheese", "Celery"
            };
        }

        public override void Bake()
        {
            Console.WriteLine($"Baking NYStyle {Name} pizza at 200 degrees");
        }


    }
}
