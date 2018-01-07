using System;

namespace DesignPatterns._04_Factory.SimpleFactory
{
    public enum Size {Small, Medium, Large};

    interface IPizza
    {
        string Name { get; set; }
        decimal Price { get; set; }
        Enum Size { get; set; }
    }
}
