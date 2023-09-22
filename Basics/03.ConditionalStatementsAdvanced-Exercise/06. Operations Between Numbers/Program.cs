using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            char sign= char.Parse(Console.ReadLine());
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
            if (result %  2 == 0)
            {
                evenOrOdd = "even";
            }
            else if (result % 2 == 1)
            {
                evenOrOdd = "odd";
            }
            if (result != 0)
            {
                Console.WriteLine($"{N1} {sign} {N2} = {result} - {evenOrOdd}");
                return;
            }
            switch (sign)
            {
                case '/':
                    result = N1 / N2;
                    break;
                case '%':
                    result = N1 % N2;
                    break;
            }
            if ( N2 == 0)
            {
                Console.WriteLine($"Cannot divide {N1} by zero");
            }
            Console.WriteLine($"{N1} {sign} {N2} = {result}");



        }
    }
}
