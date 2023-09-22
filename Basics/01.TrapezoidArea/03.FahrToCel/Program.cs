using System;

namespace _03.FahrToCel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Multiply the °C temperature by 1.8.Add 32 to this number.
            double C = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}", C * 1.8 + 32);
        }
    }
}
