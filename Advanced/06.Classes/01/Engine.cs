using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Engine
    {
        private int horsePower;
        private double cubicCapacity;

        public Engine(int horsePower, double cubicCapacity)
        {
            CubicCapacity = cubicCapacity;
            this.HorsePower = horsePower;
        }

        public double CubicCapacity
        {
            get => cubicCapacity;
            set => cubicCapacity = value;
        }
        public int HorsePower
        {
            get => horsePower;
            set => horsePower = value;
        }
    }
}
