using System;
using System.Transactions;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = 1;
            double sum = 0;
            int timesToFail = 0;
            while (grade<=12)
            {
                grade++;
                double note = double.Parse(Console.ReadLine());
                sum += note;
                if (note < 4.00)
                {
                    timesToFail++;
                    grade--;
                }
                if (timesToFail == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {grade} grade");
                    return;
                }

            }
            double total = sum / 12;
            Console.WriteLine($"{name} graduated. Average grade: {total:f2}");
        }
    }
}
