using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raiding.Models;

namespace Raiding.Factory
{
    public interface IFactory
    {
        IHero CreateHero(string name, string type);
    }
}
