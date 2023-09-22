using System;

namespace _06.Rapainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int nailon = int.Parse(Console.ReadLine());
           int paint = int.Parse(Console.ReadLine());
           int razreditel = int.Parse(Console.ReadLine());
           int hours = int.Parse(Console.ReadLine());

            double sumForMaterials = nailon * 1.5 + 3 + 0.4 + paint * 1.1 * 14.5 + razreditel * 5.0;
            double sumForWorker = hours * 0.3 * sumForMaterials;

            Console.WriteLine(sumForWorker + sumForMaterials);
        }
    }
}
