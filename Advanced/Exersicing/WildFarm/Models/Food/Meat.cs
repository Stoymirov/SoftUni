﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Food.Interfaces;

namespace WildFarm.Models.Food
{
    public class Meat:Food
    {
        public Meat(int quantity) : base(quantity)
        {
        }
    }
}
