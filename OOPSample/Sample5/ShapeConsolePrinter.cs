using System;

namespace OOPSample.Sample5
{
    internal class ShapeConsolePrinter : ShapePrinter
    {
        public override void Print(IShape shape)
        {
            Console.WriteLine($"Shape:{shape.GetType().Name}, Perimeter:{shape.GetPerimeter()}, Area:{shape.GetArea()}");
            if (shape is IHasEdges shapeHasEdges)
            {
                Console.WriteLine($"Edge Count:{shapeHasEdges.GetEdgeCount()}");
            }
        }
    }
}
