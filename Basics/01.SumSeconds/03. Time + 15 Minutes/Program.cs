using System;

namespace _03._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.input
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            //2.add15min + normalization
            minutes += 15;
            if (minutes >=60)
            {
                hours += 1;
                minutes -= 60;
            }

            if (hours >=24)
            {
                hours = 0;
            }
            
            //3. print output
            if (minutes < 10)
            {
                Console.WriteLine($"{hours}:0{minutes}");
                
            }
            else
                Console.WriteLine($"{hours}:{minutes}");

        }
    }
}
