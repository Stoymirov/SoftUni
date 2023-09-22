using System;

namespace _09._Fruit_or_Vegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string food = Console.ReadLine();
            string typeOfFood = "";
            switch (food)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    typeOfFood = "fruit";
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    typeOfFood = "vegetable";
                        break;
            }
            if (typeOfFood != "fruit" && typeOfFood != "vegetable")
            {
                typeOfFood = "unknown";
            }
            Console.WriteLine(typeOfFood);

        }
    }
}
