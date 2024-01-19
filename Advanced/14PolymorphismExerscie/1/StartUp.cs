using System.Runtime.CompilerServices;
using Vehicles;
using Vehicles.Core.Interfaces;
using Vehicles.Factory;
using Vehicles.IO;
using Vehicles.IO.Interfaces;

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