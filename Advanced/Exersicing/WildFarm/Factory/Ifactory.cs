﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Factory
{
    public interface IFactory
    {
        IAnimal Create(string[] tokens);
    }
}
