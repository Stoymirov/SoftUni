using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    public abstract class BaseHero
    {
        public abstract string Name { get;protected set; }
        public abstract int Power  { get;protected set; }

        public abstract string CastAbility();


    }

}
