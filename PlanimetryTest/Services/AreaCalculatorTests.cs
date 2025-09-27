using Planimetry.Interfaces;
using Planimetry.Services;
using Planimetry.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanimetryTest.Services
{
    [TestFixture]
    public class AreaCalculatorTests
    {
        [Test]
        public void CalculateArea_WithCircle_ReturnsCorrectArea()
        {
            // Arrange
            IShape circle = new Circle(5);
            var calculator = new AreaCalculator();
            var expectedArea = 78.53981633974483;

            // Act
            var actualArea = calculator.CalculateArea(circle);

            // Assert
            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.0001));
        }

        [Test]
        public void CalculateArea_WithTriangle_ReturnsCorrectArea()
        {
            // Arrange
            IShape triangle = new Triangle(3, 4, 5);
            var calculator = new AreaCalculator();
            var expectedArea = 6.0;

            // Act
            var actualArea = calculator.CalculateArea(triangle);

            // Assert
            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.0001));
        }

        [Test]
        public void CalculateArea_WithNullShape_ThrowsArgumentNullException()
        {
            // Arrange
            var calculator = new AreaCalculator();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => calculator.CalculateArea(null));
        }

        [Test]
        public void CalculateArea_DynamicShapeUsage_WorksCorrectly()
        {
            // Arrange - демонстрация работы без знания типа на этапе компиляции
            IShape[] shapes = new IShape[]
            {
                new Circle(2),
                new Triangle(3, 4, 5),
                new Circle(1)
            };

            var calculator = new AreaCalculator();
            var expectedAreas = new[] { 12.56637, 6.0, 3.14159 };

            // Act & Assert
            for (int i = 0; i < shapes.Length; i++)
            {
                var area = calculator.CalculateArea(shapes[i]);
                Assert.That(area, Is.EqualTo(expectedAreas[i]).Within(0.0001));
            }
        }
    }
}
