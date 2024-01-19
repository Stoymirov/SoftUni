using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raiding.Factory;
using Raiding.Models;

namespace Raiding.Core
{
    public class Engine : IEngine
    {

        IFactory factory;
        private readonly ICollection<IHero> collection;

        public Engine()
        {
            collection = new List<IHero>();
        }
        public void Run()
        {

            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {

                string name = Console.ReadLine();
                string type = Console.ReadLine();
                IHero hero = null;
                try
                {
                    factory = new Factory.Factory();
                 hero = factory.CreateHero(name, type);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }

                collection.Add(hero);
                n--;

            }


            foreach (var hero in collection)
            {
                Console.WriteLine(hero.CastAbility());
            }
            int bossPower = int.Parse(Console.ReadLine());
            int heroesPower = collection.Sum(x => x.Power);
            if (heroesPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else Console.WriteLine("Defeat...");
        }




    }
}
