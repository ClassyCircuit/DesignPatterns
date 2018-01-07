using System;
using System.Collections.Generic;
using DesignPatterns._04_Factory.AbstractFactory.BaseProducts;

namespace DesignPatterns._04_Factory.AbstractFactory.CaliforniaStyle.Products
{
    public class CaliforniaStyleGreekPizza : Pizza
    {
        public CaliforniaStyleGreekPizza(Enum size)
        {
            this.Name = "CaliforniaStyle greek";
            this.Price = 15.85m;
            this.Size = size;
            this.Sauce = "Greek sauce";
            this.Toppings = new List<string>()
            {
                "Grated hard cheese", "Blue cheese", "Salad"
            };
        }

        public override void Box()
        {
            Console.WriteLine($"Putting {Name} pizza in a hexagonal shape box");

        }
    }
}
