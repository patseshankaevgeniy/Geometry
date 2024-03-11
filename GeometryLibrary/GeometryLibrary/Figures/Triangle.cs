using GeometryLibrary.Figures.Interfaces;

namespace GeometryLibrary.Figures
{
    public class Triangle : IShape
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double CalculateSquare()
        {
            if (_sideA <= 0 || _sideB <= 0 || _sideC <= 0)
            {
                throw new ArgumentOutOfRangeException("Длины сторон треугольника должны быть положительными числами.");
            }

            double semiPerimeter = (_sideA + _sideB + _sideC) / 2;

            var square = Math.Sqrt(semiPerimeter * (semiPerimeter - _sideA) * (semiPerimeter - _sideB) * (semiPerimeter - _sideC));

            return square;
        }

        public bool IsRightAngleTriangle()
        {
            if (_sideA <= 0 || _sideB <= 0 || _sideC <= 0)
            {
                throw new ArgumentOutOfRangeException("Длины сторон треугольника должны быть положительными числами.");
            }

            double[] sides = { _sideA, _sideB, _sideC };
            Array.Sort(sides);

            var result = Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);

            return result;
        }
    }
}
