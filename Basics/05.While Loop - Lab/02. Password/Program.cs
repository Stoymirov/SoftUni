using System;

namespace _02._Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string pass = (Console.ReadLine());

            string currentpass = (Console.ReadLine());
            while (currentpass != pass)
            {
               
                currentpass = Console.ReadLine();
                
            }
            Console.WriteLine($"Welcome {name}!");
        }
    }
}
