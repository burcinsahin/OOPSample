using System;

namespace OOPSample.Sample4
{
    public abstract class Plant : Organism, IPlant
    {
        public override void Feed()
        {
            Console.WriteLine("Doing photosynthesis...");
        }
    }
}