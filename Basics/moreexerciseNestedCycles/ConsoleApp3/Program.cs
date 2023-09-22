using System;
using System.ComponentModel.Design;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int passNum = 0;
            int control = int.Parse(Console.ReadLine()); bool m = false;
            for (int i = 1000; i <= 9999; i++)
            {
                int lastDigit = i % 10;
                int thirdDigit = (i/10) % 10;
                int secondDigit = (i /100)%10;
               int firstDigit = (int)(i / Math.Pow(10, (int)Math.Log10(i)));
            
                if ((lastDigit*thirdDigit + secondDigit*firstDigit==control) && firstDigit < secondDigit && thirdDigit > lastDigit)
                {
                     m = true;
                    Console.Write($"{i} ");
                    counter++;
                    if (counter == 4)
                    {
                        passNum = i;
                    }
                }
                

            }
            if (!m || counter < 4)
            {
                if (m)
                {
                    Console.WriteLine();
                }
                Console.WriteLine("No!");
            }
            else if (counter >= 4)
            {
                Console.WriteLine();
                Console.WriteLine($"Password: {passNum}");
            }
        }
    }
}
