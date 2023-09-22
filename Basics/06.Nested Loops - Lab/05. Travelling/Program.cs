using System;

namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            
            while (destination!="End")
            {
                double sum = 0;
                double budjet = double.Parse(Console.ReadLine());
                while (sum< budjet)
                {
                    double currentMoney = double.Parse(Console.ReadLine());
                    sum += currentMoney;
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
