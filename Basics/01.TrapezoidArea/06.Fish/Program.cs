using System;

namespace _06.Fish
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mackerelP = double.Parse(Console.ReadLine());
            double spratP = double.Parse(Console.ReadLine());
            double bonitoK = double.Parse(Console.ReadLine());
            double horseMackarelK = double.Parse(Console.ReadLine());
            double musselsK = double.Parse(Console.ReadLine());

            double bonitoP = bonitoK *1.6 * mackerelP;
            double horseMackarelP = horseMackarelK * spratP * 1.8;
            double musselsP = musselsK * 7.5;

            Console.WriteLine("{0:f2}", bonitoP + horseMackarelP + musselsP );
        }
    }
}
