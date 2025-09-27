using NUnit.Framework;
using Planimetry.Shapes;

namespace PlanimetryTest.Shapes
{
    [TestFixture]
    internal class CircleTests
    {
        [Test]
        public void CalculateArea_WithValidRadius_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 5;
            var circle = new Circle(radius);
            double expectedArea = 78.53981633974483; // π * r² = 3.141592653589793 * 25

            // Act
            double actualArea = circle.CalculateArea();

            // Assert
            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.0001));
        }

        [Test]
        public void CalculateArea_WithZeroRadius_ReturnsZero()
        {
            // Arrange
            double radius = 0;
            var circle = new Circle(radius);

            // Act
            double area = circle.CalculateArea();

            // Assert
            Assert.That(area, Is.EqualTo(0));
        }

        [Test]
        public void Constructor_WithNegativeRadius_ThrowsArgumentException()
        {
            // Arrange
            double radius = -5;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }
}
