using System;

namespace AreaCalculator
{
    public class Circle : IShape
    {
        private double _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("The circle radius must be greater than 0");
            }

            _radius = radius;
        }

        public double CalculateArea()
        {
            return InternalCalculateSquare();
        }

        protected virtual double InternalCalculateSquare()
        {
            return Math.Pow(_radius, 2) * Constants.PI;
        }
    }
}
