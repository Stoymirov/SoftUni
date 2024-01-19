using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Raiding.Models;

namespace Raiding.Factory
{
    public class Factory:IFactory
    {
        public IHero CreateHero(string name, string type)
        {
            switch (type)
            {
                case "Paladin":
                    return new Paladin(name);
                case "Rogue":
                    return new Rogue(name);
                case "Warrior":
                    return new Warrior(name);
                case "Druid":
                    return new Druid(name);
                default: 
                    throw new ArgumentException("Invalid hero!");

            }
        }
    }
}
