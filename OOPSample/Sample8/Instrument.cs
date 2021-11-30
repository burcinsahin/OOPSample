using System;

namespace OOPSample.Sample8
{
    public abstract class Instrument
    {
        public virtual void Play()
        {
            Console.WriteLine($"{GetType().Name} played.");
        }
    }
}