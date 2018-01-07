using System;

namespace DesignPatterns._04_Factory.SimpleFactory
{
    public class GreekPizza : Pizza
    {
        public GreekPizza(Enum size)
        {
            this.Name = "greek";
            this.Price = 4.50m;
            this.Size = size;
        }   

        public override void Bake()
        {
            Console.WriteLine("Baking greek pizza");
        }

        public override void Box()
        {
            Console.WriteLine("Boxing greek pizza");

        }

        public override void Cut()
        {
            Console.WriteLine("Cutting greek pizza");

        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing greek pizza");

        }
    }
}
