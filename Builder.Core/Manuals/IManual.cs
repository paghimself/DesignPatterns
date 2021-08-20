using Builder.Core.Cars;

namespace Builder.Core.Manuals
{
    public interface IManual : ICar
    {
        public string GetDocumentation();
    }
}
