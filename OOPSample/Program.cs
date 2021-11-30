using System;
using System.Linq;
using System.Reflection;

namespace OOPSample
{
    class Program
    {
        private const string SampleListText = @"" +
            "Sample List: \n" +
            "2. Polymorphism Sample\n" +
            "3. Operator Overloading\n" +
            "4. Multiple Inheritance&Diamond Problem\n" +
            "5. SOLID Principles\n" +
            "6. Data Structures\n" +
            "7. Error Codes vs. Exceptions\n" +
            "8. Design Patterns: Factory Method\n";
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Now it begins.\n");
                Console.WriteLine(SampleListText);
                Console.WriteLine("Type Sample No:");

                var number = Console.ReadLine();
                if (!byte.TryParse(number, out var n))
                    throw new NotSupportedException();

                var sampleRunner = Assembly.GetExecutingAssembly()
                    .GetTypes()
                    .Single(t => t.Name == "SampleRunner" &&
                    t.Namespace.Contains($"Sample{n}"));

                sampleRunner.GetMethod("Run").Invoke(sampleRunner, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"We have an issue: {ex.Message}\n");
            }
            finally
            {
                Console.WriteLine("Now it ends.");
                Console.Read();
            }
        }
    }
}
