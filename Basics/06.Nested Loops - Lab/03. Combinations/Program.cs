using System;

namespace _03._Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i <=input; i++) 
            {
                for (int j = 0; j <= input; j++)
                {
                    for (int k = 0; k <= input; k++)
                    {
                        if (k + j + i == input)
                        {
                            counter++;
                           
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
