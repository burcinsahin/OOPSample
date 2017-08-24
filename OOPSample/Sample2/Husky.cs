using System.Diagnostics;

namespace OOPSample.Sample2
{
    internal class Husky : Dog
    {
        public override void MakeSound()
        {
            Debug.WriteLine("Auwww");
        }
    }
}