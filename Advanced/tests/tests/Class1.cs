using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests
{
    public class Vehicle : IEquatable<Vehicle>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int TirePressure { get; set; }
        public string Color  { get; set; }
        public decimal Weight { get; set; }
        public bool Equals(Vehicle? other)
        {
            if(other ==null)
                return false;
            return (Name == other.Name && other.TirePressure == this.TirePressure);
        }
    }
}
