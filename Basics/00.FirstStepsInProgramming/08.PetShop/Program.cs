using System;

namespace _08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input 
            int dogPacks = int.Parse(Console.ReadLine());
            int catPacks = int.Parse(Console.ReadLine());

            //Calculations
            double dogPacksPrice = dogPacks * 2.5;
            double catPacksPrice = catPacks * 4.0;
            double totalPrice = dogPacksPrice + catPacksPrice; 
            //Output
            Console.WriteLine(totalPrice + " lv.");
        }
    }
}
