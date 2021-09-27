using System;
using OOPSample.Sample6;

namespace OOPSample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ser Arthur Dayne says 'Now it begins.'\n");
                SampleRunner.Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Jon Snow says we have an issue: {ex.Message}\n");
            }
            finally
            {
                Console.WriteLine("Ned Stark says 'Now it ends.'");
                Console.Read();
            }
        }
    }
}
