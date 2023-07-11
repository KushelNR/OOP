using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Shape
{
    public class ShapeCalculator
    {
        public double CalculateTotalArea(Shape[] shapes)
        {
            double totalArea = 0;
            foreach (Shape shape in shapes)
            {
                totalArea += shape.CalculateArea();
            }
            return totalArea;
        }

        public double CalculateTotalArea(Circle[] shapes)
        {
            double totalArea = 0;
            foreach (Circle shape in shapes)
            {
                totalArea += shape.CalculateArea();
            }
            return totalArea;
        }
    }
}
