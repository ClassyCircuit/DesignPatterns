﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02_Observer
{
    public interface IObserver
    {
        void Update(float humidity, float temp, float pressure);
    }
}
