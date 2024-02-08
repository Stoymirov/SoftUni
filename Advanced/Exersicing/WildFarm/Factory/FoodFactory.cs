using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Food;
using WildFarm.Models.Food.Interfaces;

namespace WildFarm.Factory
{
    public class FoodFactory:IFoodFactory
    {
        public IFood CreateFood(string type, int quantity)
        {
            switch (type)
            {
                case "Vegetable":
                    return new Vegetable(quantity);
                case "Seeds":
                    return new Seeds(quantity);
                case "Fruit":
                    return new Fruit(quantity);
                case "Meat":
                    return new Meat(quantity);
                default:
                    return default;
            }
        }
    }
}
