﻿using System;

namespace _02.TriangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = a * h / 2;

            Console.WriteLine("{0:f2}", area);
        }
    }
}
