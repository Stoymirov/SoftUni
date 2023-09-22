using System;

namespace _05.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int PenPacks = int.Parse(Console.ReadLine());
          int MarkerPacks = int.Parse(Console.ReadLine());
          int Liters = int.Parse(Console.ReadLine());
          int Discount = int.Parse(Console.ReadLine());

            double Total = (PenPacks * 5.80 + MarkerPacks * 7.20 + Liters * 1.20) * (1 - 0.01 * Discount);
            Console.WriteLine(Total);
        }
    }
}
