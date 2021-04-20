using System;

namespace OOPSample.Sample5
{
    internal class Triangle : Shape, IHasEdges
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public override double GetArea()
        {
            var s = GetPerimeter()/2;
            return Math.Sqrt(s * (s - _a) * (s - _b) * (s - _c));
        }

        public override double GetPerimeter()
        {
            return _a + _b + _c;
        }

        public int GetEdgeCount()
        {
            return 3;
        }
    }
}
