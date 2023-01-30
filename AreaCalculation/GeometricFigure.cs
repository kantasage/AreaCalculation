using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculation
{
    public abstract class GeometricFigure
    {
        protected static double Pi { get => 3.14; }

        protected GeometricFigure() { }
        protected double _area => CalculateArea();
        protected abstract double CalculateArea();
    }
}
