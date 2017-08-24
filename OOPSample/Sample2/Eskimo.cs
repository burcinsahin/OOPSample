using System;
using System.Collections.Generic;

namespace OOPSample.Sample2
{
    internal class Eskimo : Human
    {
        public Eskimo()
        {
        }

        public Eskimo(IList<IAnimal> animals) : base(animals)
        {
            foreach (var animal in animals)
            {
                if (animal is Cat)
                    throw new NotSupportedException($"You can not buy {animal.GetType().Name}");
            }
        }
    }
}