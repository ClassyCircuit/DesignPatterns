using System;

namespace DesignPatterns._04_Factory.SimpleFactory
{
    public class CheesePizza : Pizza
    {
        public CheesePizza(Enum size)
        {
            this.Name = "cheese";
            this.Price = 3.20m;
            this.Size = size;
        }


        public override void Bake()
        {
            Console.WriteLine("Baking cheese pizza");
        }

        public override void Box()
        {
            Console.WriteLine("Boxing cheese pizza");

        }

        public override void Cut()
        {
            Console.WriteLine("Cutting cheese pizza");

        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing cheese pizza");

        }
    }
}
