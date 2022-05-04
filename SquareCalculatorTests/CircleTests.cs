using NUnit.Framework;
using SquareCalculator.SquareCalculator.Shapes;
using System;

namespace SquareCalculatorTests
{
    [TestFixture]
    internal class CircleTests
    {
        [TestCase(5)]
        public void CalculateArea_TestCase(int a)
        {
            var result = new Circle(a).CalculateArea();

            Assert.AreEqual(result, a * a * Math.PI);
        }

        [Test]
        public void CalculateArea_GivenNegative_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(0));
        }


    }
}