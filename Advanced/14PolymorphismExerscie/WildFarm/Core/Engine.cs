using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.IO.Interfaces;
using WildFarm.Core.Interfaces;
using WildFarm.Factories.Interfaces;
using WildFarm.Factories;
using WildFarm.Models.Interfaces;

public class Engine : IEngine
{
    IReader reader;
    IWriter writer;
    IAnimalFactory animalFactory;
    IFoodFactory foodFactory;

    private readonly ICollection<IAnimal> animals; 

    public Engine(IReader reader, IWriter writer, IAnimalFactory animalFactory, IFoodFactory foodFactory)
    {
        this.reader = reader;
        this.writer = writer;
        this.animalFactory = animalFactory;
        this.foodFactory = foodFactory;
        animals = new List<IAnimal>();

    }
    public void Run()
    {
        string input = "";
        while ((input = reader.ReadLine()) != "End")
        {
            try
            {


                string[] tokensAnimal = input.Split();
                string[] tokensFood = reader.ReadLine().Split();

                IAnimal animal = animalFactory.CreateAnimal(tokensAnimal);
                IFood food = foodFactory.Create(tokensFood[0], int.Parse(tokensFood[1]));
                animals.Add(animal);

                Console.WriteLine(animal.ProduceSound());
                animal.Eat(food);
            }
            catch (Exception ex) 

            {
                writer.WriteLine(ex.Message);
            }
        }

        foreach (var animal in animals)
        {
            Console.WriteLine(animal.ToString());
        }
    }

    

}
