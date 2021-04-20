using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
