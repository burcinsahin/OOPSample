using System;

namespace OOPSample.Sample4
{
    public abstract class Organism : IOrganism
    {
        public virtual void Feed()
        {
            Console.WriteLine("Feeding...");
        }
    }
}