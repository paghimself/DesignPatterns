using Builder.Core.Builders;
using Builder.Core.Cars;
using Builder.Core.Parts;
using Builder.Infra.Cars;

namespace Builder.Infra.Builders
{
    public class CarBuilder : IBuilder
    {
        private ICar car;


        public void Reset()
        {
            car = new Car();
        }

        public void SetModel(string model)
        {
            car.Model = model;
        }

        public void SetGPS()
        {
        }

        public void SetSeats(int seats)
        {
            car.Seats = seats;
        }

        public void SetEngine(IEngine engine)
        {
            car.Engine = engine;
        }

        public void SetTripComputer()
        {
        }

        public ICar GetResult()
        {
            return car;
        }
    }
}
