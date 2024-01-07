using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string animalType = Console.ReadLine();

                if (animalType == "Beast!")
                {
                    break;
                }

                string[] tokens = Console.ReadLine().Split();
                try
                {
                    Animal animal = CreateAnimal(animalType, tokens);
                    Console.WriteLine(animal);

                }


                catch (Exception e)
                {
                    Console.WriteLine("Invalid input!");
                }

            }

        }

        private static Animal CreateAnimal(string animalType, string[] tokens)
        {
            switch (animalType)
            {
                case "Dog":
                {
                    return new Dog(tokens[0], int.Parse(tokens[1]), tokens[2]);

                }
                case "Frog":
                {
                    return new Frog(tokens[0], int.Parse(tokens[1]), tokens[2]);

                }
                case "Cat":
                {
                    return new Cat(tokens[0], int.Parse(tokens[1]), tokens[2]);

                }
                case "Tomcat":
                {
                    return new Tomcat(tokens[0], int.Parse(tokens[1]));

                }
                case "Kitten":
                {
                    return new Kitten(tokens[0], int.Parse(tokens[1]));


                }
                default:
                    throw new ArgumentException("Invalid animal input!");


            }
        }
    }
}