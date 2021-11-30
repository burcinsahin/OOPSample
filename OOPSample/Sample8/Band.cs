using System;

namespace OOPSample.Sample8
{
    public abstract class Band
    {
        protected Instrument[] instruments;

        protected Band()
        {
            CreateInstruments();
        }

        public void Play()
        {
            Console.WriteLine(GetType().Name + " starts playing...");
            foreach (var instrument in instruments)
            {
                instrument.Play();
            }
            Console.WriteLine(GetType().Name + " ends playing.\n");
        }

        public abstract void CreateInstruments();
    }
}