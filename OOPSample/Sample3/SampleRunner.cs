using System;

namespace OOPSample.Sample3
{
    public class SampleRunner
    {
        public static void Run()
        {
            var matrix1 = new Matrix2D(new[,]
            {
                {2.3, 4.1},
                {1.7, 2.1},
                {3.3, 5.2}
            });

            var matrix2 = new Matrix2D(new[,]
            {
                {2.7, 1.3},
                {1.9, 2.7},
                {1.3, 0.9}
            });

            var addMatrix = matrix1 + matrix2;
            var subMatrix = matrix1 - matrix2;
            var mulMatrix1 = 0.5 * matrix1;

            Console.WriteLine("Added matrix:");
            Console.WriteLine(addMatrix.ToString());

            Console.WriteLine("Subtracted matrix:");
            Console.WriteLine(subMatrix.ToString());

            Console.WriteLine("Multiplied matrix by a constant:");
            Console.WriteLine(mulMatrix1.ToString());
        }
    }
}