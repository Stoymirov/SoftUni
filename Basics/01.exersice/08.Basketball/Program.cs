using System;

namespace _08.Basketball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int YP = int.Parse(Console.ReadLine());

            Console.WriteLine(0.6 * YP + YP + 0.8 * 0.6 * YP + 0.25 * 0.6 * 0.8 * YP + 0.2 * 0.25 * 0.6 * 0.8 * YP);
        }
    }
}
