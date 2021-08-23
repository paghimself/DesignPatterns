using AbstractFactory.Core.Buttons;

namespace AbstractFactory.Infra.Buttons
{
    public class WindowsButton : IButton
    {
        public void Paint()
        {
            System.Console.WriteLine("WindowsButton: Paint()");
        }
    }
}
