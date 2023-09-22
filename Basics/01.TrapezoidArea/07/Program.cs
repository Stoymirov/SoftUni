using System;

namespace _07_
{
    internal class Program
    {
        static void Main(string[] args)
        { 
        //area = π · r2, parameter = 2*r*p
        double r = double.Parse(Console.ReadLine());

        double area = r * r * Math.PI;
        double parameter = 2 * r * Math.PI;
            Console.WriteLine("{0;f2}", area);
            Console.WriteLine("{0;f2}", parameter);

        }
    }
}
