using Raiding.Core;

namespace Raiding;

public class StartUp
{
    static void Main(string[] args)
    {
        IEngine engine = new Engine();
        engine.Run();
    }
}