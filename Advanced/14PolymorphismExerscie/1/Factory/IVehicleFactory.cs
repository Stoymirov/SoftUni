﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Models.Interfaces;

namespace Vehicles.Factory
{
    public interface IVehicleFactory
    {
        IVehicle Create(string type, double fuelQuantity, double fuelConsumption,double tankCapacity);
    }
}
