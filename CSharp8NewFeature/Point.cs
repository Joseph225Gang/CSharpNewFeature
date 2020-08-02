using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8NewFeature
{
    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Distance => Math.Sqrt(X * X + Y * Y);

        public override string ToString() =>
            $"({X}, {Y}) is {Distance} from the origin";
    }
}
