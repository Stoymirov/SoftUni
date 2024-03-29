﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models
{
    public class Truck:Vehicle
    {
        private const double IncreasedConsumption = 1.6;
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, IncreasedConsumption, tankCapacity)
        {
        }

        public override void Refuel(double amount)
        {
            if (amount + FuelQuantity > TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {amount} fuel in the tank");
            }
            base.Refuel(amount*0.95);
        }
    }
}
/*Car 15 0.3
 Truck 100 0.9
 4
 Drive Car 9
 Drive Car 30
 Refuel Car 50
 Drive Truck 10*/