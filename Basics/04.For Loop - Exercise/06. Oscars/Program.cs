using System;
using System.Linq;
using System.Xml.Schema;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameActor = Console.ReadLine();
            int point = int.Parse(Console.ReadLine());
            int juryNumber = int.Parse(Console.ReadLine());
            double sum = 0;
           
            for (int i = 1; i <= juryNumber; i++) 
            {
            string nameJury = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());
                
                int l = nameJury.Length;
                sum += (( l * points) / 2) ;
                
            }
            double totalSum = sum + point;
            if (totalSum > 1250.5)
            {
                Console.WriteLine($"Congratulations, {nameActor} got a nominee for leading role with {totalSum:f1}!");
            }
            else
            Console.WriteLine ($"Sorry, {nameActor} you need {1250.5 - totalSum:f1} more!");
        }
    }
}
