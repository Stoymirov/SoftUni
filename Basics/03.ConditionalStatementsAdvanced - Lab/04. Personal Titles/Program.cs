using System;

namespace _04._Personal_Titles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            if (age >= 16)
            {
                if (gender == "f")
                {
                    Console.WriteLine("Ms.");
                }
                else if (gender == "m")
                {
                    Console.WriteLine("Mr.");
                }
            }
            else
            {
                if (gender == "f")
                    Console.WriteLine("Miss");
                if (gender == "m")
                    Console.WriteLine("Master");
            }

        }
    }
}
