using System.Diagnostics;

namespace OOPSample.Sample4
{
    public abstract class Organism : IOrganism
    {
        public virtual void Feed()
        {
            Debug.WriteLine("Feeding...");
        }
    }
}