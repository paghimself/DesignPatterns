using AbstractFactory.Core.Buttons;
using AbstractFactory.Core.Checkboxes;
using AbstractFactory.Infra.Buttons;
using AbstractFactory.Infra.Checkboxes;

namespace AbstractFactory.Infra.Factories
{
    public class MacFactory : IGUIFactory
    {

        public IButton Button { get; set; }
        public ICheckbox Checkbox { get; set; }

        public IButton CreateButton()
        {
            Button = new MacButton();
            return Button;
        }

        public ICheckbox CreateCheckbox()
        {
            Checkbox = new MacCheckbox();
            return Checkbox;
        }
    }
}
