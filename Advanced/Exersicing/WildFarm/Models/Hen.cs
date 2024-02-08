using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Food;

namespace WildFarm.Models
{
    public class Hen:Bird
    {
        private const double HenWM = 0.35;
        public Hen(string name, double wingSize, double weight) : base(name, wingSize, weight)
        {
        }

        public override ICollection<Type> Collection => new HashSet<Type>()
            { typeof(Meat), typeof(Fruit), typeof(Seeds), typeof(Vegetable) };
        public override string SoundProducer()
        {
            return "Cluck";
        }

        protected override double WeightMultiplier => HenWM;
    }
}
