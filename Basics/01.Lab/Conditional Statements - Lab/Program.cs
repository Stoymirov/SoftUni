﻿using System;

namespace Conditional_Statements___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade >= 5.50) 
            {
                Console.WriteLine("Excellent!");
            }

        }
    }
}