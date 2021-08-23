using FactoryMethod.Core.Transports;

namespace FactoryMethod.Core.Creators
{
    public abstract class TransportationCreator
    {        
        public abstract Transport CreateTransport();
        public void Build()
        {
            //other business logic can be implemented to send any good
            //no matter the Transportation method we use

            Transport transport = CreateTransport();
            transport.WhoAmI();
            transport.Deliver("all the goods!");
        }

    }
}
