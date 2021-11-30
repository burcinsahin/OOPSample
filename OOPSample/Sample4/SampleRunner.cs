namespace OOPSample.Sample4
{
    public class SampleRunner
    {
        public static void Run()
        {
            var nepenthes = new Nepenthes();
            nepenthes.Feed();

            var plant = (IPlant)nepenthes;
            plant.Feed();

            var carnivorous = (ICarnivorous)nepenthes;
            carnivorous.Feed();
        }
    }
}