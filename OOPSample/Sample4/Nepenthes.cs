using System.Diagnostics;

namespace OOPSample.Sample4
{
    public class Nepenthes : IPlant, ICarnivorous
    {
        public void Feed()
        {
            Debug.WriteLine("Eating another organism...");
        }
    }
}
