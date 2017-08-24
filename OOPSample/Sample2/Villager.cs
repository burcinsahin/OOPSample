using System.Collections.Generic;

namespace OOPSample.Sample2
{
    internal class Villager : Human
    {
        public Villager()
        {
        }

        public Villager(IList<IAnimal> animals) : base(animals)
        {
        }
    }
}