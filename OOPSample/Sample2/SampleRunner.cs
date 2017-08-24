using System.Collections.Generic;

namespace OOPSample.Sample2
{
    public class SampleRunner
    {
        public static void Run()
        {
            var world = new World();
            world.AddHuman(new GodFather(new List<IAnimal>
            {
                new Cat(),
                new Cat(),
                new Dog(),
                new Husky()
            }));

            world.AddHuman(new Eskimo(new List<IAnimal>
            {
                new Dog(),
                new Husky()
            }));
            world.AddHuman(new Villager(new List<IAnimal>
            {
                new Cat(),
                new Dog()
            }));

            foreach (var human in world.Humans)
            {
                human.PokeAnimal();
            }
        }
    }
}
