using AbstractFactory.Core.Buttons;
using AbstractFactory.Core.Checkboxes;
using AbstractFactory.Infra.Buttons;
using AbstractFactory.Infra.Checkboxes;

namespace AbstractFactory.Infra.Factories
{
    public class WindowsFactory : IGUIFactory
    {
        public IButton Button { get; set; }
        public ICheckbox Checkbox { get; set; }

        public IButton CreateButton()
        {
            Button = new WindowsButton();
            return Button;
        }

        public ICheckbox CreateCheckbox()
        {
            Checkbox = new WindowsCheckbox();
            return Checkbox;
        }
    }
}
