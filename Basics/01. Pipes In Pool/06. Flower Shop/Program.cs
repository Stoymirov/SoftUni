using System;

namespace _06._Flower_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mangolii = int.Parse(Console.ReadLine());
            int hyacinth = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cacti = int.Parse(Console.ReadLine());
            double gift = double.Parse(Console.ReadLine());
            double totalFlowerPrice = (mangolii * 3.25 + hyacinth * 4 + roses * 3.5 + cacti * 8) * 0.95 ;
            if (totalFlowerPrice >= gift)
            
                Console.WriteLine($"She is left with {Math.Floor(totalFlowerPrice - gift)} leva.");
            else     
                Console.WriteLine($"She will have to borrow {Math.Ceiling(gift - totalFlowerPrice)} leva.");
            
        }
    }
}
