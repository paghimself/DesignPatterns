using FactoryMethod.Core.Creators;
using FactoryMethod.Infra.Creators;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            TransportationCreator landCreator = new LandCreator();
            TransportationCreator seaCreator = new SeaCreator();

            landCreator.Build();
            seaCreator.Build();

        }
    }
}
