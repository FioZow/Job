using NUnit.Framework;
using SquareCalculator.SquareCalculator.Shapes;
using System;

namespace SquareCalculatorTests
{
    [TestFixture]
    internal class TriangleTests
    {
        [Test]
        public void IsRightTriangle_ExpectTrue()
        {
            var result = new Triangle(3, 4, 5).isRightTriangle;

            Assert.AreEqual(result, true);
        }

        [Test]
        public void IsRightTriangle_ExpectFalse()
        {
            var result = new Triangle(3, 4, 2).isRightTriangle;

            Assert.AreEqual(result, false);
        }

        [TestCase(0, 5, 3)]
        [TestCase(15, 1, 2)]
        public void CreatingTriangle_TestCase_GivenInvalidParameters_ThrowsArgumentOutOfRangeException(int a, int b, int c)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(a, b, c));
        }

        [TestCase(3, 4, 5, 6)]
        [TestCase(10, 16, 10, 48)]
        public void CalculateArea_TestCase(double a, double b, double c, double expected)
        {
            var result = new Triangle(a, b, c).CalculateArea();

            Assert.AreEqual(expected, result);
        }
    }
}