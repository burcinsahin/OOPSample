using System;

namespace OOPSample.Sample2
{
    internal class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Meoww");
        }
    }
}