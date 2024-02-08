using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Food;

namespace WildFarm.Models
{
    public class Tiger:Feline
    {
        private const double TigerWM = 1;
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override ICollection<Type> Collection => new HashSet<Type>(){typeof(Meat)};
        public override string SoundProducer()
        {
            return "ROAR!!!";
        }

        protected override double WeightMultiplier => 1;
    }
}
