using System;

namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examH = int.Parse(Console.ReadLine());
            int examM = int.Parse(Console.ReadLine());
            int arrivalH = int.Parse(Console.ReadLine());
            int arrivalM = int.Parse(Console.ReadLine());

            int examInM = 60 * examH + examM;
            int arrivalInM = 60 * arrivalH + arrivalM;

            string accuracy = "";
            if (examInM - 30 > arrivalInM)
            {
                accuracy = "Early";
            }
            else if (examInM < arrivalInM)
            {
                accuracy = "Late";
            }
            else if (examInM - 30 <= arrivalInM)
            {
                accuracy = "On time";
            }
            int timeDiff = Math.Abs(examInM - arrivalInM);
            string afterOrBefore = "";
            if ( examInM < arrivalInM )
            {
                afterOrBefore = "after";
            }
            else if (examInM > arrivalInM)
            {
                afterOrBefore = "before";
            }
            int hours = 0;
            int minutes = 0;
            if (timeDiff >=60)
            {
                hours = timeDiff / 60;
                minutes = timeDiff % 60;
            }
            Console.WriteLine(accuracy);
            if (timeDiff >= 60)
            {
                if (minutes <10)
                Console.WriteLine($"{hours}:0{minutes} hours {afterOrBefore} the start");
                else
                    Console.WriteLine($"{hours}:{minutes} hours {afterOrBefore} the start");
            }
            else if (timeDiff < 60 && timeDiff != 0)
                Console.WriteLine($"{timeDiff} minutes {afterOrBefore} the start");
        }
    }
}
