using System;

namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string nameOfMovie = Console.ReadLine();
            int totalTicketsCount = 0; int studentTickets = 0, kidsTickets = 0, standartTicket = 0;
            while (nameOfMovie != "Finish")
            {
                
                int freeSeats = int.Parse(Console.ReadLine());
                int soldTickets = 0;
                for (int i = 0; i < freeSeats; i++)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType =="End")
                    {
                        break;
                    }
                    if(ticketType =="student") { studentTickets++; }
                    else if (ticketType =="standard") {standartTicket++; }
                    else if (ticketType =="kid") { kidsTickets++; }
                    soldTickets++;
                }
                 totalTicketsCount += soldTickets;
                double fillPercentage = (100.0 * soldTickets) / freeSeats;
                Console.WriteLine($"{nameOfMovie} - {fillPercentage:f2}% full.");
                nameOfMovie = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalTicketsCount}");
            Console.WriteLine($"{studentTickets*100.0/totalTicketsCount:f2}% student tickets.");
            Console.WriteLine($"{standartTicket*100.0/totalTicketsCount:f2}% standard tickets.");
            Console.WriteLine($"{kidsTickets*100.0/totalTicketsCount:f2}% kids tickets.");
        }
    }
}
