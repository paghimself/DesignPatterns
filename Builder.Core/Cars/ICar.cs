using Builder.Core.Parts;

namespace Builder.Core.Cars
{
    public interface ICar
    {
        public int Seats { get; set; }
        public string Model { get; set; }
        public IEngine Engine { get; set; }

    }
}
