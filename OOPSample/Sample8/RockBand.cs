namespace OOPSample.Sample8
{
    public class RockBand : Band
    {
        public override void CreateInstruments()
        {
            instruments = new Instrument[]
            {
                new BassGuitar(),
                new Drums(),
                new ElectricGuitar(),
                new Keyboard()
            };
        }
    }
}