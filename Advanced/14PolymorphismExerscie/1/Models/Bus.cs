using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models
{
    public class Bus:Vehicle
    {
        private const double increase = 1.4;
        public Bus(double fuelQuantity, double fuelConsumption, double tank) : base(fuelQuantity, fuelConsumption, increase,tank)
        {
        }

       
    }
    
}
