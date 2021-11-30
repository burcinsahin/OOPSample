namespace OOPSample.Sample8
{
    public class FlamencoBand : Band
    {
        public override void CreateInstruments()
        {
            instruments = new Instrument[]
            {
                new ClassicalGuitar(),
                new ClassicalGuitar()
            };
        }
    }
}