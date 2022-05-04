using System;
using System.Linq;

namespace SquareCalculator.SquareCalculator.Shapes
{
    class Triangle : IShape
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;
        public readonly bool isRightTriangle;

        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
            isRightTriangle = IsRightTriangle();
        }

        public double CalculateArea()
        {
            var p = (_sideA + _sideB + _sideC) / 2;

            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }

        private bool IsRightTriangle()
        {
            var maxSide = new[] { _sideA, _sideB, _sideC }.Max();

            return maxSide * maxSide * 2 == _sideA * _sideA + _sideB * _sideB + _sideC * _sideC;
        }
    }
}
