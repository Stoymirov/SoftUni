using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Food.Interfaces;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public abstract class Animal:IAnimal
    {
        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
           
        }

        public abstract ICollection<Type> Collection { get;}
       protected abstract double WeightMultiplier { get; }

        public string Name { get; }
        public double Weight { get; private set; }
        public int FoodEaten { get; private set; }

       public void Eat(IFood food)
       {
           if (Collection.All(x => food.GetType().Name != x.Name))
           {
               throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
           }

           Weight += food.Quantity * WeightMultiplier;
           FoodEaten += food.Quantity;
       }
       public abstract string SoundProducer();

       public override string ToString()
           => $"{GetType().Name} [{Name}, ";

    }
}
