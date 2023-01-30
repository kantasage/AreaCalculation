using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculation.Figures
{
    public class Circle : GeometricFigure
    {
        public double Radius { get; }
        public double Area => _area;
        public Circle(double radius)
        {
            if(radius<=0)
                throw new ArgumentOutOfRangeException("Данные стороны не образуют треугольник");
            Radius = radius;
        }
        protected sealed override double CalculateArea()
        {
            return Pi * Radius * Radius;
        }
        public static double CalculateArea(double radius)
        {
            if (radius <= 0)
                return 0;
            return Pi * radius * radius;
        }
    }
}
