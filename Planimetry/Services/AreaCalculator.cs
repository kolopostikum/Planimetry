using Planimetry.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planimetry.Services
{
    /// <summary>
    /// Calculates the area of a shape.
    /// </summary>
    public class AreaCalculator
    {
        /// <summary>
        /// Calculates the area of a shape.
        /// </summary>
        /// <param name="shape">The shape to calculate the area for.</param>
        /// <returns>The area of the shape.</returns>
        public double CalculateArea(IShape shape)
        {
            // Throws an exception if shape is null.
            return shape?.CalculateArea() ?? throw new ArgumentNullException("shape cannot be null");
        }
    }
}
