﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Shape
    {
        public abstract double CalculateArea();

        public void Display()
        {
            Console.WriteLine("Displaying shape...");
        }
    }
}
