using System;

namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  сума = депозирана сума + срок на депозита * ((депозирана сума * годишен лихвен процент ) /
            double Deposit = double.Parse(Console.ReadLine());
            int Time = int.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());
            double Total = (Deposit + Time * ((Deposit * tax * 0.01) / 12));
            Console.WriteLine(Total);
        }
    }
}
