using System;

namespace OOPSample.Sample2
{
    internal class Dog : IAnimal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Woof..");
        }
    }
}