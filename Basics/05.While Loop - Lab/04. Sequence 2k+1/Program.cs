using System;

namespace _04._Sequence_2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = 1;
            while (n >= m)
            {
                Console.WriteLine(m);
                m = m * 2 + 1;
            }
        }
    }
}
