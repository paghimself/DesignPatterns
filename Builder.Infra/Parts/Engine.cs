using Builder.Core.Parts;

namespace Builder.Infra.Parts
{
    public class Engine : IEngine
    {
        public Engine(int hp)
        {
            HP = hp;
        }

        public int HP { get; set; }
    }
}
