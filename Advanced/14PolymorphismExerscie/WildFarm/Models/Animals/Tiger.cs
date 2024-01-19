using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using WildFarm.Foods;

namespace WildFarm.Models.Animals
{
    public class Tiger : Feline
    {
        private const double TigerWM = 1;
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override double WeightMultiplier => TigerWM;

        public override IReadOnlyCollection<Type> PreferredFoods =>
            new HashSet<Type>() { typeof(Meat) };
        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
    }
}