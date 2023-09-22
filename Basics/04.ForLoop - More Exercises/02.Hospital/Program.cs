using System;

namespace _02.Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = int.Parse(Console.ReadLine());
            int patientsTakenCareFor = 0;
            int patientsUntakenCareFor = 0;
            int maxADay = 7;
            for (int i = 1; i <= time; i++)
            {
                if (i % 3 == 0 && patientsUntakenCareFor > patientsTakenCareFor)
                {
                    maxADay++;
                }
                
                {

                    int patientNumber = int.Parse(Console.ReadLine());
                    if (patientNumber <= maxADay)
                    {
                        patientsTakenCareFor += patientNumber;
                    }
                    else
                    {
                        patientsTakenCareFor += maxADay;
                        patientsUntakenCareFor += patientNumber - maxADay;
                    }
                }
                
            }
            Console.WriteLine($"Treated patients: {patientsTakenCareFor}.");
            Console.WriteLine($"Untreated patients: {patientsUntakenCareFor}.");
        }
    }
}
