using System.Collections.Generic;

namespace OOPSample.Sample2
{
    internal class World
    {
        public World()
        {
            Humans = new List<IHuman>();
        }

        public List<IHuman> Humans { get; }

        public void AddHuman(IHuman human)
        {
            Humans.Add(human);
        }
    }
}