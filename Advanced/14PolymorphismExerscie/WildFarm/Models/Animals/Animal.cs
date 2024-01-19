﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models.Animals
{
    public abstract class Animal : IAnimal
    {
        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
        public string Name { get; private set; }
        public double Weight { get; private set; }
        public int FoodEaten { get; private set; }

        public abstract double WeightMultiplier { get; }
        public abstract IReadOnlyCollection<Type> PreferredFoods { get; }
        public abstract string ProduceSound();
        

        public void Eat(IFood food)
        {
            if (PreferredFoods.All(pf => pf.Name != food.GetType().Name))
            {
                throw new Exception($"{this.GetType().Name} does not eat {food.GetType().Name}");
            }

            Weight += food.Quantity * WeightMultiplier;
            FoodEaten += food.Quantity;
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, ";
        }

    }
}
