using System;
using System.Collections.Generic;
using DesignPatterns._04_Factory.AbstractFactory.BaseProducts;

namespace DesignPatterns._04_Factory.AbstractFactory.CaliforniaStyle.Products
{
    public class CaliforniaStyleCheesePizza : Pizza
    {
        public CaliforniaStyleCheesePizza(Enum size)
        {
            this.Name = "CaliforniaStyle cheese";
            this.Price = 10.14m;
            this.Size = size;
            this.Sauce = "Bastila sauce";
            this.Toppings = new List<string>()
            {
                "olives", "paprika", "lettuce"
            };
        }
    }
}
