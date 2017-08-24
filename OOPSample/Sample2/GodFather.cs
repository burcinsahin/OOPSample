using System.Collections.Generic;

namespace OOPSample.Sample2
{
    internal class GodFather : Human
    {
        public GodFather()
        {
        }

        public GodFather(IList<IAnimal> animals) : base(animals)
        {
        }
    }
}