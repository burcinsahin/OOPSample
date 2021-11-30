using System.Collections.Generic;

namespace OOPSample.Sample5
{
    internal class SampleRunner
    {
        public static void Run()
        {
            var shapes = new List<IShape>
            {
                new Rectangle(3, 5),
                new Square(6),
                new Triangle(3, 4, 5),
                new Circle(10)
            };

            Rectangle rectangle = new Square(5);
            shapes.Add(rectangle);

            var shapePrinter = DependencyResolver.GetShapePrinter();

            foreach (var shape in shapes)
            {
                shapePrinter.Print(shape);
            }
        }
    }
}
