using System;

namespace _06_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            int input3 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input1; i++)
            {
                for (int j = 1; j <= input2; j++)
                {
                    for (int k = 1; k <= input3; k++)
                    {
                        if (i%2 ==0&& k%2 ==0 && (j ==3 || j == 5 || j ==7 ||j ==2))
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }
        }
    }
}
