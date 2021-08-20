using Builder.Core.Cars;
using Builder.Core.Manuals;
using Builder.Infra.Builders;
using Builder.Infra.Directors;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new();
            CarBuilder builder = new();
            CarManualBuilder manBuilder = new();
            //director.MakeSportsCar(builder);
            //ICar mazda = builder.GetResult();
            //System.Console.WriteLine(mazda);


            director.MakeSUVCar(builder);
            ICar suv = builder.GetResult();
            System.Console.WriteLine(suv);

            director.MakeSUVManual(manBuilder);
            IManual suvMan = manBuilder.GetResult();
            System.Console.WriteLine(suvMan.GetDocumentation());

        }
    }
}
