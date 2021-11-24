using System;

namespace OOPSample.Sample7
{
    internal class SampleRunner
    {
        public static void Run()
        {
            var methodResult = Divide(5, 5);
            if (methodResult.HasError)
            {
                Console.WriteLine($"{methodResult.ErrorCode}-{methodResult.ErrorMessage}");
            }
            else
            {
                Console.WriteLine(methodResult.Data);
            }

            try
            {
                var result = Divide2(5, 5);
                Console.WriteLine(result);
            }
            catch (MyException ex)
            {
                Console.WriteLine($"{ex.ErrorCode}-{ex.Message}");
            }
        }

        public static MethodResult<double> Divide(double a, double b)
        {
            if (b == 0)
                return new MethodResult<double>(1, "Divider must be a value other than zero!");

            return new MethodResult<double>(a / b);
        }

        public static double Divide2(double a, double b)
        {
            if (b == 0)
                throw new MyException(1, "Divider must be a value other than zero!");

            return a / b;
        }
    }
}