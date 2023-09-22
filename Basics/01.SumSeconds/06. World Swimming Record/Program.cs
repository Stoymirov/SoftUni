using System;
using System.Xml.Schema;

namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double record = double.Parse(Console.ReadLine());
           double meters = double.Parse(Console.ReadLine());
           double secondsPerMeter = double.Parse(Console.ReadLine());
            double TimeNoResistance = meters * secondsPerMeter;
            double ResistanceTime =Math.Floor((meters / 15)) * 12.5;
            double IvanTime = ResistanceTime + TimeNoResistance;

            if (IvanTime < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {IvanTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs((record - IvanTime)):f2} seconds slower.");
            }
        }
    }
}
