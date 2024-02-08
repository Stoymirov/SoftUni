using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Food;

namespace WildFarm.Models
{
    public class Dog:Mammal
    {
        private const double DogWM = 0.4;
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override ICollection<Type> Collection => new HashSet<Type>() { typeof(Meat) };
        public override string SoundProducer()
        {
            return "Woof!";
        }

        protected override double WeightMultiplier => DogWM;


    }
}
