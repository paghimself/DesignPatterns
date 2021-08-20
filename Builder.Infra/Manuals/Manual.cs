using Builder.Core.Manuals;
using Builder.Core.Parts;

namespace Builder.Infra.Manuals
{
    public class Manual : IManual
    {
        public int Seats { get; set; }
        public string Model { get; set; }
        public IEngine Engine { get; set; }

        public string GetDocumentation()
        {
            string output = string.Empty;
            output += $"\n=======================================================================\n";
            output += $"\t\t\t   {Model}\n";
            output += $"lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum \n";
            output += $"lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum \n";
            output += $"lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum \n";
            output += $"lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum \n";
            output += $"lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum \n";
            output += $"Number of seats = {Seats}.\n";
            output += $"lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum \n";
            output += $"lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum \n";
            output += $"lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum \n";
            output += $"lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum lorem ipsum \n";
            output += $"The engine has {Engine.HP} HP.\n";
            output += $"=======================================================================\n\n";

            return output;
        }

    }
}
