using System;

namespace _09.Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percantage = double.Parse(Console.ReadLine());

            double volume = lenght * width * height * 0.001;
            Console.WriteLine(volume * (1 - percantage * 0.01));
        }
    }
}
