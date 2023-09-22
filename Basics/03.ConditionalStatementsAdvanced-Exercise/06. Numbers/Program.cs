using System;
using System.Reflection.Metadata;

namespace _06._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            char sign = char.Parse(Console.ReadLine());
            double result = 0;
            string evenOrOdd = "";
            
            switch (sign)
            {
                case '+':
                    result = N1 + N2;
                    break;
                case '-':
                    result = N1 - N2;
                    break;
                case '*':
                    result = (N1 * N2);
                    break;
                    
            }
            if (result % 2 == 0)
            {
                evenOrOdd = "even";
            }
            else 
            {
                evenOrOdd = "odd";
            }
            if (sign == '+' || sign == '-' || sign == '*') 
            { Console.WriteLine($"{N1} {sign} {N2} = {result} - {evenOrOdd}"); return; }
            
            
            if (N2 == 0)
            {
                Console.WriteLine($"Cannot divide {N1} by zero");
                return;
            }
            
            switch (sign)
            {
                case '/':
                    result = N1 / (double)N2;
                    break;
                case '%':
                    result = N1 % N2;
                    break;
            }
            if(sign == '/')
            {
                Console.WriteLine($"{N1} {sign} {N2} = {result:f2}");
            }
            else
            Console.WriteLine($"{N1} {sign} {N2} = {result}");

        }
    }
}
