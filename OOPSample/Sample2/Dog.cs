using System;
using System.Diagnostics;

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