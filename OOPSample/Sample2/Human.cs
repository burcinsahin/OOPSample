using System.Collections.Generic;
using System.Diagnostics;

namespace OOPSample.Sample2
{
    internal abstract class Human : IHuman
    {
        private IList<IAnimal> Animals { get; set; }

        protected Human()
        {
            Animals = new List<IAnimal>();
        }

        protected Human(IList<IAnimal> animals)
        {
            Animals = animals;
        }

        public virtual void BuyAnimal(IAnimal animal)
        {
            Animals.Add(animal);
        }

        public void PokeAnimal()
        {
            Debug.WriteLine($"I am a {GetType().Name}");
            foreach (var animal in Animals)
            {
                Debug.WriteLine($"I poked my animal {animal.GetType().Name}.");
                animal.MakeSound();
            }
        }
    }
}