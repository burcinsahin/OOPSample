namespace OOPSample.Sample1
{
    public class Car
    {
        private int velocity;

        private int gear;

        private EngineStatus engineStatus;

        public Car()
        {
            velocity = 0;
            gear = 1;
            engineStatus = EngineStatus.Stopped;
        }
    }
}
