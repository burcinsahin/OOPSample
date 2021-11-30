using System.IO;

namespace OOPSample.Sample5
{
    internal class ShapeFilePrinter : ShapePrinter
    {
        public override void Print(IShape shape)
        {
            File.AppendAllLines(@"./temp.txt", new[] { $"Shape:{shape.GetType().Name}, Perimeter:{shape.GetPerimeter()}, Area:{shape.GetArea()}" });
            if (shape is IHasEdges shapeHasEdges)
            {
                File.AppendAllLines(@"./temp.txt", new[] { $"Edge Count:{shapeHasEdges.GetEdgeCount()}" });
            }
        }
    }
}
