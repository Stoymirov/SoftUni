using System;

namespace _04_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            int counterTo3 = 0;
                int counterTo4 = 0;
                int counterTo5 = 0;
            int counterTo6 = 0;
            double totalGradeCounter = 0;
           
                for (int i = 1; i <= numberOfStudents; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 3)
                {
                    counterTo3++;
                }
                else if (grade < 4)
                {
                    counterTo4++;
                }
                else if (grade < 5)
                {
                    counterTo5++;
                }
                else
                {
                    counterTo6++;
                }
                totalGradeCounter += grade;
                
            }
            double percentageTo3 = (counterTo3 * 100.0) / numberOfStudents;
            double percentageTo4 = (counterTo4 * 100.0) / numberOfStudents;
            double percentageTo5 = (counterTo5 * 100.0) / numberOfStudents;
            double percentageTo6 = (counterTo6 * 100.0) / numberOfStudents;
            double average = totalGradeCounter/ numberOfStudents;
            Console.WriteLine($"Top students: {percentageTo6:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {percentageTo5:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {percentageTo4:F2}%");
            Console.WriteLine($"Fail: {percentageTo3:f2}%");
            Console.WriteLine($"Average: {average:F2}");

        }
    }
}
