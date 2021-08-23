using FactoryMethod.Core.Transports;

namespace FactoryMethod.Infra.Transports
{
    public class Boat : Transport
    {
        public void Deliver(string goods)
        {
            System.Console.WriteLine($"Boat delivery: {goods}");
        }

        public void WhoAmI()
        {
            System.Console.WriteLine("A boat");
        }
    }
}
