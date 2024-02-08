using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Food.Interfaces;

namespace WildFarm.Models.Food
{
    public abstract class Food:IFood
    {
      
        public int Quantity { get; }

        protected Food(int quantity)
        {
            Quantity = quantity;
        }
    }
}
