using Planimetry.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planimetry.Services
{
    public class AreaCalculator
    {
        public double CalculateArea(IShape shape)
        {
            return shape != null ? shape.CalculateArea() : throw new ArgumentNullException("shape cannot be null");
        }
    }
}
