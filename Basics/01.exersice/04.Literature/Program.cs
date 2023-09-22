using System;

namespace _04.Literature
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int Pages = int.Parse(Console.ReadLine());
          int PagesPerHour = int.Parse(Console.ReadLine());
          int Days = int.Parse(Console.ReadLine());

            double HoursADay = Pages/(PagesPerHour * Days);
            Console.WriteLine(HoursADay);
        }
    }
}
