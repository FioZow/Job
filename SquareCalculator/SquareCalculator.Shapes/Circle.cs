using System;

namespace SquareCalculator.SquareCalculator.Shapes
{
    public class Circle : IShape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException("Invalid radius value.");
            _radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }


    }
}
