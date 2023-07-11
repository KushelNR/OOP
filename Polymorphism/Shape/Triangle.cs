﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Shape
{
    public class Triangle : Shape
    {
        private double baseLength;
        private double height;

        public Triangle(double baseLength, double height)
        {
            this.baseLength = baseLength;
            this.height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * baseLength * height;
        }
    }
}
