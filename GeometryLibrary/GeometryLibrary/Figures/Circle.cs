using GeometryLibrary.Figures.Interfaces;

namespace GeometryLibrary.Figures
{
    public class Circle : IShape
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double CalculateSquare()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
