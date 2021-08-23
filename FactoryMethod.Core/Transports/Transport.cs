namespace FactoryMethod.Core.Transports
{
    public interface Transport
    {
        void WhoAmI();
        void Deliver(string goods);
    }
}
