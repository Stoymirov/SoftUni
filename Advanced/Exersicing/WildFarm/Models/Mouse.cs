using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Food;

namespace WildFarm.Models
{
    public class Mouse:Mammal
    {
        private const double MouseWM = 0.1;
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override ICollection<Type> Collection => new HashSet<Type>() { typeof(Vegetable), typeof(Fruit) };
        public override string SoundProducer()
        {
            return "Squeak";
        }

        protected override double WeightMultiplier => MouseWM;

       
    }
}
