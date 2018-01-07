using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DesignPatterns._04_Factory.AbstractFactory.BaseProducts
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Enum Size { get; set; }
        public string Sauce { get; set; }
        public List<string> Toppings;

        public virtual void Prepare()
        {
            Console.WriteLine($"Preparing {Name} pizza");
            Console.WriteLine($"Adding {Sauce}");
            Console.Write($"Adding toppings:");
            foreach (var topping in Toppings)
            {
                Console.Write($" {topping}");
            }
        }

        public virtual void Bake()
        {
            Console.WriteLine($"Baking {Name} pizza");
        }

        public virtual void Cut()
        {
            Console.WriteLine($"Cutting {Name} pizza");

        }

        public virtual void Box()
        {
            Console.WriteLine($"Putting {Name} pizza in a box");
        }
    }
}
