﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Foods;

namespace WildFarm.Models.Animals
{
    public class Mouse:Mammal
    {
        private const double MouseWM = 0.1;
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override double WeightMultiplier => MouseWM;

        public override IReadOnlyCollection<Type> PreferredFoods =>
            new HashSet<Type>() { typeof(Fruit), typeof(Vegetable) };
        public override string ProduceSound()
        {
            return "Squeak";
        }
        public override string ToString()
        {
            return base.ToString() + $"{Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
