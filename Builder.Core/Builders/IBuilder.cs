using Builder.Core.Parts;

namespace Builder.Core.Builders
{
    public interface IBuilder
    {
        public void Reset();

        public void SetModel(string model);

        public void SetSeats(int seats);

        public void SetEngine(IEngine engine);

        public void SetTripComputer();

        public void SetGPS();
    }
}
