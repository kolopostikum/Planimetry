using Planimetry.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planimetry.Shapes
{
    /// <summary>
    /// Represents a Triangle shape.
    /// </summary>
    public class Triangle : IShape
    {
        public Triangle(int v1, int v2, int v3)
        {
            CheckTriangleSides(v1, v2, v3);
            V1 = v1;
            V2 = v2;
            V3 = v3;
        }

        public int V1 { get; }
        public int V2 { get; }
        public int V3 { get; }

        /// <summary>
        /// Calculates the area of the triangle.
        /// </summary>
        /// <returns>The area of the triangle.</returns>
        public double CalculateArea()
        {
            var p = (V1 + V2 + V3) / 2;
            return Math.Sqrt(p * (p - V1) * (p - V2) * (p - V3));
        }

        /// <summary>
        /// Checks if the triangle is a right triangle.
        /// </summary>
        /// <returns><c>true</c> if the triangle is a right triangle; otherwise, <c>false</c>.</returns>
        public bool IsRightTriangle()
        {
            return V1 * V1 + V2 * V2 == V3 * V3 
                || V1 * V1 + V3 * V3 == V2 * V2 
                || V2 * V2 + V3 * V3 == V1 * V1;
        }

        private static void CheckTriangleSides(int v1, int v2, int v3)
        {
            if (v1 <= 0 || v2 <= 0 || v3 <= 0)
                throw new ArgumentException("Sides must be positive");

            if (v1 + v2 <= v3 || v1 + v3 <= v2 || v2 + v3 <= v1)
                throw new ArgumentException("Sides must form a triangle");
        }
    }
}
