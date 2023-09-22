using System;

namespace _04_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napishete broi na predmeti.");
            string juryMembers =(Console.ReadLine());
            Console.WriteLine("Napishete ime na uchenika.(kogato ste gotovi napishete -Stop i shte se izchisli sredna ocenka na vsichki uchenici.)");
            string imeNaChovek = Console.ReadLine();
            
            double totalSumOfGrades = 0;
            int cycleCounter = 0;
            while (juryMembers !="Stop")
            {
                int howManySubjects = int.Parse(juryMembers);
                double sumOfGrades = 0;
                for (int i = 0; i < howManySubjects; i++)
                {
                    Console.WriteLine("Napishete ocenka.");
                    double currentGrade = double.Parse(Console.ReadLine());
                    sumOfGrades += currentGrade;

                }
                totalSumOfGrades += sumOfGrades/howManySubjects;
                cycleCounter++;

                Console.WriteLine($"{imeNaChovek} - {sumOfGrades / howManySubjects:f2} sreden uspeh.");
                Console.WriteLine("Napishete broi predmeti.");
                juryMembers =(Console.ReadLine());
                if (juryMembers != "Stop")
                {
                    Console.WriteLine("Napishete ime na uchenika.");
                    imeNaChovek = Console.ReadLine();
                }
            }
            Console.WriteLine($"Sredna ocenka na svischki uchenici - {totalSumOfGrades / cycleCounter:f2}.");
        }
    }
}
