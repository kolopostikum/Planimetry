using NUnit.Framework;
using Planimetry.Shapes;

namespace Planimetry.Tests.Shapes
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void CalculateArea_WithValidSides_ReturnsCorrectArea()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);
            var expectedArea = 6.0; // Heron's formula

            // Act
            var actualArea = triangle.CalculateArea();

            // Assert
            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.0001));
        }

        [Test]
        public void IsRightTriangle_WithRightTriangle_ReturnsTrue()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var isRight = triangle.IsRightTriangle();

            // Assert
            Assert.That(isRight, Is.True);
        }

        [Test]
        public void IsRightTriangle_WithNonRightTriangle_ReturnsFalse()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 6);

            // Act
            var isRight = triangle.IsRightTriangle();

            // Assert
            Assert.That(isRight, Is.False);
        }

        [Test]
        public void Constructor_WithInvalidSides_ThrowsArgumentException()
        {
            // Negative side
            Assert.Throws<ArgumentException>(() => new Triangle(-1, 2, 3));

            // Impossible triangle
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 10));
        }

        [Test]
        public void CalculateArea_WithZeroSide_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(0, 4, 5));
        }
    }
}