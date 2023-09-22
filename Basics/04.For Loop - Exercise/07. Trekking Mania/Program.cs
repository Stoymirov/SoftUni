using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupNumber = int.Parse(Console.ReadLine());
            int p1 = 0; int p2 = 0; int p3 = 0; int p4 = 0; int p5 = 0;
            for (int i = 0; i < groupNumber; i++)
                
            {
                int peopleInGroup = int.Parse(Console.ReadLine());
                if (peopleInGroup <= 5)
                {
                    p1 += peopleInGroup;
                }
                else if (peopleInGroup <= 12) 
                { 
                p2 += peopleInGroup;
                }
                else if (peopleInGroup <= 25)
                {
                    p3 += peopleInGroup;
                }
                else if (peopleInGroup <= 40)
                {
                    p4 += peopleInGroup;
                }
                else 
                {
                    p5 += peopleInGroup;
                }
                
            }

            Console.WriteLine($"{(p1 *100.0) / (p1 + p2 + p3 + p4 + p5):f2}%");
            Console.WriteLine($"{(p2 *100.0) / (p1 + p2 + p3 + p4 + p5):f2}%");
            Console.WriteLine($"{(p3 *100.0) / (p1 + p2 + p3 + p4 + p5):f2}%");
            Console.WriteLine($"{(p4 *100.0) / (p1 + p2 + p3 + p4 + p5):f2}%");
            Console.WriteLine($"{(p5 *100.0) / (p1 + p2 + p3 + p4 + p5):f2}%");
        }
    }
}
