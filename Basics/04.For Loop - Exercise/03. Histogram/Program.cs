using System;
using System.Threading.Channels;

namespace _03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0; int p2 =0; int p3 = 0; int p4 = 0; int p5 = 0;
           
           
            for (int i = 0;i < n;i++)
            {
                int number = int.Parse(Console.ReadLine()); 
                if (number <200)
                {
                    p1++;
                }
                else if (number >= 200 && number <400)
                {
                    p2++;
                }
                else if (number >= 400 && number < 600)
                {
                    p3++;
                }
                else if (number >= 600 && number < 800)
                {
                    p4++;
                }
                else { p5++;}
                
                
            }
            Console.WriteLine($"{(p1 * 100.0) / n:f2}%");
            Console.WriteLine($"{(p2 * 100.0) / n:f2}%");
            Console.WriteLine($"{(p3 * 100.0) / n:f2}%");
            Console.WriteLine($"{(p4 * 100.0) / n:f2}%");
            Console.WriteLine($"{(p5 * 100.0) / n:f2}%");

        }
        
    }
}
