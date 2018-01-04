﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03_Decorator.CoffeeShop
{
    public interface IBeverage
    {
        string Description { get; }
        decimal Cost { get; }
        Enum Size { get; set; }
    }
}
