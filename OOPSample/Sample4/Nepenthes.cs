using System;

namespace OOPSample.Sample4
{
    public class Nepenthes : IPlant, ICarnivorous
    {
        public void Feed()
        {
            Console.WriteLine("Eating another organism...");
        }
    }
}
