using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using WildFarm.Foods;

namespace WildFarm.Models.Animals
{
    public class Cat:Feline
    {
        private const double CatWM = 0.3;
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override double WeightMultiplier => CatWM;

        public override IReadOnlyCollection<Type> PreferredFoods =>
            new HashSet<Type>() { typeof(Meat), typeof(Vegetable) };
        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
