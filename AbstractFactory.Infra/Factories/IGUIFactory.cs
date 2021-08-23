using AbstractFactory.Core.Buttons;
using AbstractFactory.Core.Checkboxes;

namespace AbstractFactory.Infra.Factories
{
    public interface IGUIFactory
    {
        IButton Button { get; set; }
        ICheckbox Checkbox { get; set; }

        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}
