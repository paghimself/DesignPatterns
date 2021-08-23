using AbstractFactory.Core.Checkboxes;

namespace AbstractFactory.Infra.Checkboxes
{
    public class WindowsCheckbox : ICheckbox
    {
        public void Draw()
        {
            System.Console.WriteLine("WindowsCheckbox: Draw()");
        }
    }
}
