namespace OOPSample.Sample5
{
    internal static class DependencyResolver
    {
        public static IShapePrinter GetShapePrinter()
        {
            return new ShapeConsolePrinter();
            //return new ShapeFilePrinter();
        }
    }
}
