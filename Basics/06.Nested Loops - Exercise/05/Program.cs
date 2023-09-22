using System;

namespace _05_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1111; i <= 9999; i++) 
            {
                bool b = true;
                int mm = i;
                int lastDigit = mm % 10;
                for (int j = 0; j < 4; j++)
                {
                    if (lastDigit == 0)
                    {
                        b = false;
                        break;
                    }
                    if (n % lastDigit == 0)
                    {
                        mm/= 10;
                    }
                    else
                    { b = false; break; }
                    lastDigit = mm%10;
                }

                if (b) 
                Console.Write($"{i} ") ;
            }
        }
    }
}
