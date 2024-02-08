using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Models
{
    public abstract class Feline:Mammal

    {
        protected Feline(string name, double weight, string livingRegion,string breed) : base(name, weight, livingRegion)
        {
            Breed = breed;
        }

        private string Breed { get; }

        public override string ToString()
        {
           return $"{this.GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }

    }
}
