using Planimetry.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planimetry.Shapes
{
    public class Circle : IShape
    {
        public Circle(double radius)
        {
            if (radius < 0) throw new ArgumentException("Radius must be greater than zero.");
            Radius = radius;
        }

        public double Radius { get; }

        public double CalculateArea() => Math.PI * Radius * Radius;
    }
}
