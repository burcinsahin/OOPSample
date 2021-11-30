namespace OOPSample.Sample1
{
    public class Car
    {
        private readonly int velocity;

        private readonly int gear;

        private readonly EngineStatus engineStatus;

        public Car()
        {
            velocity = 0;
            gear = 1;
            engineStatus = EngineStatus.Stopped;
        }
    }
}
