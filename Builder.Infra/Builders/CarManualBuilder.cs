using Builder.Core.Builders;
using Builder.Core.Manuals;
using Builder.Core.Parts;
using Builder.Infra.Manuals;

namespace Builder.Infra.Builders
{
    public class CarManualBuilder : IBuilder
    {
        private IManual manual;


        public void Reset()
        {
            manual = new Manual();
        }
        public void SetModel(string model)
        {
            manual.Model = model;
        }

        public void SetGPS()
        {
        }

        public void SetSeats(int seats)
        {
            manual.Seats = seats;
        }

        public void SetTripComputer()
        {
        }

        public void SetEngine(IEngine engine)
        {
            manual.Engine = engine;
        }

        public IManual GetResult()
        {
            return manual;
        }
    }
}
