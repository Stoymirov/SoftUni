using System;

namespace _0._2GreaterNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           int myInt = int.Parse(Console.ReadLine());
           int myInt2 = int.Parse(Console.ReadLine());
            if (myInt > myInt2)
            {
                Console.WriteLine(myInt);
            }
            else
            {
                Console.WriteLine(myInt2);
                     
            }
        }
    }
}
