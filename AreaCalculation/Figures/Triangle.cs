using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculation.Figures
{
    public class Triangle : GeometricFigure
    {
        public double FirstSide { get; }
        public double SecondSide { get; }
        public double ThirdSide { get; }
        public bool IsTriangleRight => IsTriangleRightAngled(FirstSide, SecondSide, ThirdSide);
        public double Area => _area;
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide + secondSide <= thirdSide || firstSide + thirdSide <= secondSide
                || secondSide + thirdSide <= firstSide)
                throw new ArgumentOutOfRangeException("Данные стороны не образуют треугольник");
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }
        protected override double CalculateArea()
        {
            double p = (FirstSide + SecondSide + ThirdSide) / 2;
            return Math.Sqrt(p * (p - FirstSide) * (p - SecondSide) * (p - ThirdSide));
        }
        public static double CalculateArea(double firstSide, double secondSide, double thirdside)
        {
            if (firstSide + secondSide <= thirdside || firstSide + thirdside <= secondSide || secondSide + thirdside <= firstSide) // стороны формируют треугольник? 
                return 0;
            double p = (firstSide + secondSide + thirdside) / 2;
            return Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdside));
        }
        public static bool IsTriangleRightAngled(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide + secondSide <= thirdSide || firstSide + thirdSide <= secondSide || secondSide + thirdSide <= firstSide) // стороны формируют треугольник? 
                return false;
            if (firstSide * firstSide + secondSide * secondSide == thirdSide * thirdSide || firstSide * firstSide + thirdSide * thirdSide == secondSide * secondSide || secondSide * secondSide + thirdSide * thirdSide == firstSide * firstSide)
                return true;
            return false;
        }
    }
}
