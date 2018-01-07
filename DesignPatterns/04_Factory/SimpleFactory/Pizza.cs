using System;

namespace DesignPatterns._04_Factory.SimpleFactory
{
    public abstract class Pizza : IPizza
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Enum  Size { get; set; }

        public abstract void Prepare();
        public abstract void Bake();
        public abstract void Cut();
        public abstract void Box();
    }
}
