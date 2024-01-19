using System.Runtime.CompilerServices;
using Vehicles;

using Vehicles.Factory;
using WildFarm.Core.Interfaces;
using WildFarm.IO;
using WildFarm.IO.Interfaces;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IVehicleFactory factory = new VehicleFactory();


            IEngine engine = new Engine(reader, writer, factory);
            engine.Run();
        }
    }
}