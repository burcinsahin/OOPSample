namespace OOPSample.Sample8
{
    internal class SampleRunner
    {
        public static void Run()
        {
            var bands = new Band[2]
            {
                new RockBand(),
                new FlamencoBand()
            };

            foreach (var band in bands)
            {
                band.Play();
            }
        }
    }
}