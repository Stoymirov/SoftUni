using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models;
using WildFarm.Models.Interfaces;

namespace WildFarm.Factory
{
    public class Factory:IFactory
    {
        public IAnimal Create(string[] tokens)
        {
            switch (tokens[0])
            {
                case "Mouse":
                    return new Mouse(tokens[1], double.Parse(tokens[2]), tokens[3]);
                case "Dog":
                    return new Dog(tokens[1], double.Parse(tokens[2]), tokens[3]);
                case "Cat":
                    return new Cat(tokens[1], double.Parse(tokens[2]), tokens[3], tokens[4]);
                case "Tiger":
                    return new Tiger(tokens[1], double.Parse(tokens[2]), tokens[3], tokens[4]);
                case "Hen":
                    return new Hen(tokens[1], double.Parse(tokens[3]), double.Parse(tokens[2]));
                case "Owl":
                    return new Owl(tokens[1], double.Parse(tokens[3]), double.Parse(tokens[2]));
                default:
                    return default;


            }
        }
    }
}
