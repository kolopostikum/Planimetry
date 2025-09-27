using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planimetry.Interfaces
{
    /// <summary>
    /// Interface for shapes with an area.
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Calculate the area of the shape.
        /// </summary>
        /// <returns>The area of the shape.</returns>
        public double CalculateArea();
    }
}
