using AbstractFactory.Core.Buttons;

namespace AbstractFactory.Infra.Buttons
{
    public class MacButton : IButton
    {
        public void Paint()
        {
            System.Console.WriteLine("MacButton: Paint()");
        }
    }
}
