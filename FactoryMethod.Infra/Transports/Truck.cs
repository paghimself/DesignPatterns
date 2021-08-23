using FactoryMethod.Core.Transports;

namespace FactoryMethod.Infra.Transports
{
    public class Truck : Transport
    {

        public void Deliver(string goods)
        {
            System.Console.WriteLine($"Truck delivery: {goods}");
        }

        public void WhoAmI()
        {
            System.Console.WriteLine("A truck");
        }
    }
}
