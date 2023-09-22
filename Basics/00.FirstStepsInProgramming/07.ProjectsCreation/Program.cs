using System;

namespace _07.ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string architectName = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());

            //Calculations
            int hours = projects * 3;

            //Output
            Console.WriteLine($"The architect {architectName} will need {hours} hours to complete {projects} project/s.");
        }
    }
}
