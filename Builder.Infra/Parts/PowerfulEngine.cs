using Builder.Core.Parts;

namespace Builder.Infra.Parts
{
    public class PowerfulEngine : IEngine
    {
        public PowerfulEngine(int hp)
        {
            HP = hp;
        }

        public int HP { get; set; }
    }
}
