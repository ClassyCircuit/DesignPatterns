using DesignPatterns._04_Factory.AbstractFactory.BaseProducts;

namespace DesignPatterns._04_Factory.AbstractFactory.NYStyle.Ingredients
{
    internal class ReggyCheese : ICheese
    {
        public string Name { get; set; }
        public ReggyCheese()
        {
            this.Name = "Reggy cheese";
        }
    }
}