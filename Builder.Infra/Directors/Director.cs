using Builder.Core.Builders;
using Builder.Infra.Parts;

namespace Builder.Infra.Directors
{
    public class Director
    {
        public void MakeSUVCar(IBuilder builder)
        {
            builder.Reset();
            builder.SetModel("Pathfinder");
            builder.SetGPS();
            builder.SetSeats(8);
            builder.SetEngine(new Engine(100));
            builder.SetTripComputer();
        }

        public void MakeSUVManual(IBuilder builder)
        {
            builder.Reset();
            builder.SetModel("Pathfinder");
            builder.SetGPS();
            builder.SetSeats(8);
            builder.SetEngine(new Engine(100));
            builder.SetTripComputer();
        }

        public void MakeSportsCar(IBuilder builder)
        {
            builder.Reset();
            builder.SetModel("Mazda");
            builder.SetGPS();
            builder.SetSeats(2);
            builder.SetEngine(new PowerfulEngine(333));
            builder.SetTripComputer();
        }


    }
}
