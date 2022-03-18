using AreaCalculator;
using NUnit.Framework;
using System;

namespace TestProject1
{
    public class FigureAreaCalculationTests
    {
        const double precisely = 0.0000001;

        [Test]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(5.134)]
        public void Calculate_Ñircle_Area_Test(double radius)
        {
            // Arrange
            IShape shape = new Circle(radius);

            // Act
            
            double result = FigureAreaCalculator.CalculateArea(shape);
            double expectedResult = 3.14 * radius * radius;

            // Assert
            Assert.IsTrue(Math.Abs(result - expectedResult) < precisely);
        }


        [Test]
        [TestCase(0)]
        [TestCase(-23.2)]
        public void Calculate_Ñircle_Area_With_Incorrect_Radius_Test(double radius)
        {
            // Arrange
            try
            {
                IShape shape = new Circle(radius);
            }
            // Assert
            catch (Exception ex)
            {
                Assert.IsTrue(ex is ArgumentException);
            }

            // Act, Assert
            Assert.Throws<ArgumentException>(() => FigureAreaCalculator.CalculateArea(new Circle(radius)));
        }

        [Test]
        [TestCase(2, 2, 3, 1.984313483298443)]
        [TestCase(3, 4, 5, 6)]
        public void Calculate_Triangle_Area_Test(double x, double y, double z, double expectedResult)
        {
            // Arrange
            IShape shape = new Triangle(x, y, z);

            // Act
            double result = FigureAreaCalculator.CalculateArea(shape);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }


        [Test]
        [TestCase(2, 2, 10)]
        [TestCase(-3, -4, -5)]
        [TestCase(0, 0, 0)]
        [TestCase(0, -2, 0)]
        public void Calculate_Triangle_Area_With_Incorrect_Sides_Test(double x, double y, double z)
        {
            // Arrange
            try
            {
                IShape shape = new Triangle(x, y, z);
            }
            // Assert
            catch (Exception ex)
            {
                Assert.IsTrue(ex is ArgumentException);
            }

            // Act, Assert
            Assert.Throws<ArgumentException>(() => FigureAreaCalculator.CalculateArea(new Triangle(x, y, z)));
        }
    }
}