using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public abstract class Bird :Animal, IBird

    {
        protected Bird(string name,double wingSize, double weight):base(name, weight)
        {
            WingSize = wingSize;
        }

        public double WingSize { get; }
        public override string ToString()
        {
            return base.ToString() + $"{WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
