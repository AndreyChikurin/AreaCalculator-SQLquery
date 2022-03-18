using System;

namespace AreaCalculator
{
    public class Triangle : IShape
    {
        private double _x;
        private double _y;
        private double _z;
        private bool _isRectangular;

        public Triangle(double x, double y, double z)
        {
            if (x >= y + z || y >= x + z || z >= x + y)
            {
                throw new ArgumentException("The triangle is set incorrectly");
            }

            _x = x;
            _y = y;
            _z = z;

            _isRectangular = CheckIfRectangular();
        }

        public double CalculateArea()
        {
            return InternalCalculateSquare();
        }

        protected virtual double InternalCalculateSquare()
        {
            // Общая формула расчета площади любого корректного треугольника
            if (!_isRectangular)
            {
                double halfPerimetr = (_x + _y + _z) / 2;

                return Math.Sqrt(halfPerimetr * (halfPerimetr - _x) * (halfPerimetr - _y) * (halfPerimetr - _z));
            }

            // Формулы расчета для прямогульного трегольника
            if (_x > _y && _x > _z)
            {
                return (_y * _z) / 2;
            }

            if (_y > _x && _y > _z)
            {
                return (_x * _z) / 2;
            }

            return (_x * _y) / 2;
        }

        //Проверка, является ли треугольник прямоугольным через формулу Пифагора
        private bool CheckIfRectangular()
        {
            const double precisely = 0.0000001;

            double side1 = CalculateSideLength(_y, _z);
            double side2 = CalculateSideLength(_x, _z);
            double side3 = CalculateSideLength(_x, _y);

            return Math.Abs(_x - side1) < precisely || Math.Abs(_y - side2) < precisely || Math.Abs(_z - side3) < precisely;
        }

        private double CalculateSideLength(double s1, double s2)
        {
            return Math.Sqrt(Math.Pow(s1, 2) + Math.Pow(s2, 2));
        }
    }
}
