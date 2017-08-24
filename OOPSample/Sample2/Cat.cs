using System.Diagnostics;

namespace OOPSample.Sample2
{
    internal class Cat : IAnimal
    {
        public void MakeSound()
        {
            Debug.WriteLine("Meoww");
        }
    }
}