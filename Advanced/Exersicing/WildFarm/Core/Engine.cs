using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Core.Interfaces;
using WildFarm.Factory;
using WildFarm.IO.Interfaces;
using WildFarm.Models.Food.Interfaces;
using WildFarm.Models.Interfaces;

namespace WildFarm.Core
{
    public class Engine:IEngine
    {
        private IFactory factory;
        private IFoodFactory foodFactory;
        private IWriter writer;
        private IReader reader;

        private readonly ICollection<IAnimal> animals;
        public Engine(IFactory animalFactory, IFoodFactory foodFactory, IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
            this.factory = animalFactory;
            this.foodFactory = foodFactory;
            animals = new List<IAnimal>();
        }
        public void Run()
        {
            string command = "";
            while ((command = reader.ReadLine()) != "End")
            {
                string[] animalTokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string[] foodTokens = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                IAnimal animal = null;
                IFood food = null;
                try
                {
                     animal = factory.Create(animalTokens);
                     food = foodFactory.CreateFood(foodTokens[0], int.Parse(foodTokens[1]));
                     animals.Add(animal);
                     writer.WriteLine(animal.SoundProducer());
                     animal.Eat(food);
                }
                catch (Exception ex)
                {
                    writer.WriteLine(ex.Message);
                }
                
            }

            foreach (var animal in animals)
            {
                writer.WriteLine(animal.ToString());
            }
        }

    }
}
