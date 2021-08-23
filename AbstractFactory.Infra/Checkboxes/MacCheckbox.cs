using AbstractFactory.Core.Checkboxes;

namespace AbstractFactory.Infra.Checkboxes
{
    public class MacCheckbox : ICheckbox
    {
        public void Draw()
        {
            System.Console.WriteLine("MacCheckbox: Draw()");
        }
    }
}
