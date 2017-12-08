using System.Diagnostics;

namespace OOPSample.Sample4
{
    public abstract class Carnivorous : Organism, ICarnivorous
    {
        public override void Feed()
        {
            Debug.WriteLine("Eating another organism...");
        }
    }
}