using GeometryLibrary.Figures;

namespace GeometryLibrary.Tests
{
    [TestFixture]
    public class GeometryCalculatorTests
    {
        [Test]
        public void CalculateCircleArea_ValidRadius_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 5;
            Circle circle = new Circle(radius);

            // Act
            double area = circle.CalculateSquare();

            // Assert
            Assert.AreEqual(Math.PI * radius * radius, area);
        }

        [Test]
        public void CalculateTriangleArea_ValidSides_ReturnsCorrectArea()
        {
            // Arrange
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            Triangle triangle = new Triangle(side1, side2, side3);

            // Act
            double area = triangle.CalculateSquare();

            // Assert
            Assert.AreEqual(6, area);
        }

        [Test]
        public void IsRightAngleTriangle_ValidTriangle_ReturnsTrue()
        {
            // Arrange
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            Triangle triangle = new Triangle(side1, side2, side3);

            // Act
            bool isRightAngle = triangle.IsRightAngleTriangle();

            // Assert
            Assert.IsTrue(isRightAngle);
        }

        [Test]
        public void IsRightAngleTriangle_InvalidTriangle_ReturnsFalse()
        {
            // Arrange
            double side1 = 1;
            double side2 = 2;
            double side3 = 3;
            Triangle triangle = new Triangle(side1, side2, side3);

            // Act
            bool isRightAngle = triangle.IsRightAngleTriangle();

            // Assert
            Assert.IsFalse(isRightAngle);
        }
    }
}