using AbstractFactory.Infra.Factories;
using System;

namespace AbstractFactory
{
    class Program
    {
        public static IGUIFactory factory;
        public static string Config { get; set; } = "windows";

        static void Main(string[] args)
        {

            if (Config == "windows")
            {
                factory = new WindowsFactory();
            }
            else if (Config == "mac")
            {
                factory = new MacFactory();
            }
            else
            {
                throw new InvalidOperationException("Unknown OS");
            }

            factory.CreateButton();
            factory.CreateCheckbox();
            factory.Button.Paint();
            factory.Checkbox.Draw();

        }

    }
}
