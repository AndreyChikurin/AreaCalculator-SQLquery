namespace AreaCalculator
{
    public static class FigureAreaCalculator
    {
        public static double CalculateArea(IShape shape)
        {
            return shape.CalculateArea();
        }

        public static double CalculateCircleArea(double radius)
        {
            Circle circle = new Circle(radius);

            return circle.CalculateArea();
        }

        public static double CalculateTriangleArea(double x, double y, double z)
        {
            Triangle triangle = new Triangle(x, y, z);

            return triangle.CalculateArea();
        }
    }
}
