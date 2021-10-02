using System;

namespace OOPSample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Now it begins.\n");
                Console.WriteLine("Type Sample No:");
                string number = Console.ReadLine();
                switch (number)
                {
                    case "2":
                        Sample2.SampleRunner.Run();
                        break;
                    case "3":
                        Sample3.SampleRunner.Run();
                        break;
                    case "4":
                        Sample4.SampleRunner.Run();
                        break;
                    case "5":
                        Sample5.SampleRunner.Run();
                        break;
                    case "6":
                        Sample6.SampleRunner.Run();
                        break;
                    default:
                        throw new NotSupportedException();
                }
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
