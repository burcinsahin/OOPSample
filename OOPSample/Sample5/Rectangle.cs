namespace OOPSample.Sample5
{
    internal class Rectangle : Shape, IHasEdges
    {
        private readonly double _a;
        private readonly double _b;

        public Rectangle(double a, double b)
        {
            _a = a;
            _b = b;
        }

        public override double GetArea()
        {
            return _a * _b;
        }

        public override double GetPerimeter()
        {
            return 2 * (_a + _b);
        }

        public int GetEdgeCount()
        {
            return 4;
        }
    }
}
