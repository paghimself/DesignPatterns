using FactoryMethod.Core.Creators;
using FactoryMethod.Core.Transports;
using FactoryMethod.Infra.Transports;

namespace FactoryMethod.Infra.Creators
{
    public class SeaCreator : TransportationCreator
    {
        public override Transport CreateTransport()
        {
            return new Boat();
        }
    }
}
