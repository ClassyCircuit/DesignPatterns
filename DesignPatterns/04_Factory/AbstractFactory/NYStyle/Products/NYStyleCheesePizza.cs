using System;
using System.Collections.Generic;
using DesignPatterns._04_Factory.AbstractFactory.BaseProducts;

namespace DesignPatterns._04_Factory.AbstractFactory.NYStyle.Products
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza(Enum size)
        {
            this.Name = "NYStyle cheese";
            this.Price = 8.99m;
            this.Size = size;
            this.Sauce = "Happy sauce";
            this.Toppings = new List<string>()
            {
                "olives", "chili", "cherry tomatoes"
            };
        }
 
    }
}
