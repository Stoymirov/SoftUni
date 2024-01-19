using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Models;
using Vehicles.Models.Interfaces;

namespace Vehicles.Factory
{
    public class VehicleFactory:IVehicleFactory
    {
        public IVehicle Create(string type, double fuelQuantity, double fuelConsumption,double tankCapacity)
        {
            switch (type)
            {
                case "Car":
                    Car car = new Car(fuelQuantity, fuelConsumption, tankCapacity);
                    return car;

                case "Truck":
                    Truck truck = new Truck(fuelQuantity, fuelConsumption, tankCapacity);
                    return truck;
                case "Bus":
                    Bus bus = new Bus(fuelQuantity, fuelConsumption, tankCapacity);
                    return bus;
                default:
                    throw new ArgumentException("Invalid vehicle type");
            }
        }

      
    }
}
