using WildFarm.Core;
using WildFarm.Core.Interfaces;
using WildFarm.Factory;
using WildFarm.IO;

namespace WildFarm;

public class StartUp
{
    public static void Main(string[] args)
    {
        IEngine engine = new Engine(new Factory.Factory(), new FoodFactory(), new ConsoleReader(), new ConsoleWriter());
        engine.Run();
    }
}