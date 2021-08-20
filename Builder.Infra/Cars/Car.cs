using Builder.Core.Cars;
using Builder.Core.Parts;

namespace Builder.Infra.Cars
{
    public class Car : ICar
    {
        public int Seats { get; set; }
        public string Model { get; set; }
        public IEngine Engine { get; set; }

        public override string ToString()
        {
            return $"Model {Model} has {Seats} seats and and engine with {Engine.HP} horsepower.";
        }

    }
}
