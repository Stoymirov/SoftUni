
using WildFarm.Core.Interfaces;
using WildFarm.Factories;
using WildFarm.Factories.Interfaces;
using WildFarm.IO;
using WildFarm.IO.Interfaces;
using ConsoleWriter = WildFarm.IO.ConsoleWriter;

namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            IAnimalFactory factory = new AnimalFactory();
            IFoodFactory foodFactory = new FoodFactory();

            IEngine engine = new Engine(reader, writer, factory, foodFactory);

            engine.Run();
        }
    }
}
