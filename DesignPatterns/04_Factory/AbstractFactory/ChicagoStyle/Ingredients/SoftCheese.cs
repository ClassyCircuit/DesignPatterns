using DesignPatterns._04_Factory.AbstractFactory.BaseProducts;

namespace DesignPatterns._04_Factory.AbstractFactory.ChicagoStyle.Ingredients
{
    internal class SoftCheese : ICheese
    {
        public string Name { get; set; }

        public SoftCheese()
        {
            this.Name = "Soft cheese";
        }
    }
}