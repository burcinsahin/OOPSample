using System;

namespace OOPSample.Sample4
{
    public abstract class Carnivorous : Organism, ICarnivorous
    {
        public override void Feed()
        {
            Console.WriteLine("Eating another organism...");
        }
    }
}