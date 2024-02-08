using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Food;
using WildFarm.Models.Food.Interfaces;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Owl:Bird
    {
        private const double OwlWM = 0.25;
        public Owl(string name, double wingSize, double weight) : base(name, wingSize, weight)
        {
        }

        public override ICollection<Type> Collection => new HashSet<Type>() { typeof(Meat) };
        public override string SoundProducer()
        {
            return "Hoot Hoot";
        }

        protected override double WeightMultiplier => OwlWM;
    }
}
