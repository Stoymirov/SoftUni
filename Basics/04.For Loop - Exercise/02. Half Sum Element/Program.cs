using System;

namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;
            
            for (int i = 1; i <= n; i++) 
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;
                if (currentNumber > max)
                {
                    max = currentNumber;
                }
            }
            bool isValid = max * 2 == sum;
            if (isValid)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
               
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(max * 2 -sum)}");
            }


        }
    }
}
