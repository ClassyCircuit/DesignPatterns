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

        protected Dough dough { get; set; }
        protected Sauce sauce { get; set; }
        protected Veggies[] veggies { get; set; }
        protected Cheese cheese { get; set; }
        protected Pepperoni pepperoni { get; set; }
        protected Clams clams { get; set; }


        public abstract void Prepare();

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
