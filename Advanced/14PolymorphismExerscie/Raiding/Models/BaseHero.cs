using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    public abstract class BaseHero:IHero
    {
        public string Name { get;protected set; }
        public int Power  { get;protected set; }

        protected BaseHero(string name,int power)
        {
            
            Name = name ;
            Power = power;

        }
        public abstract string CastAbility();


    }

}
