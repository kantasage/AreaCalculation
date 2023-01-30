using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCalculation.Figures;
using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculation.Tests
{
    [TestClass()]
    public class AreaTests
    {
        [TestMethod]
        public void CircleAreaTest()
        {
            double radius = 1;
            double expexted = 3.14;

            var circle = new Circle(radius);
            Assert.AreEqual(expexted, circle.Area);
            Assert.AreEqual(expexted, Circle.CalculateArea(radius));
        }

        [TestMethod]
        public void TriangleAreaTest()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            var triangle = new Triangle(a,b,c);
            Assert.AreEqual(expected, triangle.Area);
            Assert.AreEqual(expected, Triangle.CalculateArea(a,b,c));
        }

        [TestMethod()]
        public void IsTriangleRightTest()
        {
            double a = 7;
            double b = 24;
            double c = 25;
            bool expected = true;

            var triangle = new Triangle(a, b, c);
            Assert.AreEqual(expected, triangle.IsTriangleRight);
            Assert.AreEqual(expected, Triangle.IsTriangleRightAngled(a, b, c));
        }
    }
}