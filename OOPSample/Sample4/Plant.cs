using System.Diagnostics;

namespace OOPSample.Sample4
{
    public abstract class Plant : Organism, IPlant
    {
        public override void Feed()
        {
            Debug.WriteLine("Doing photosynthesis...");
        }
    }
}