using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string soughtBook = Console.ReadLine();
            int sum = 0;
            string nextBook = Console.ReadLine();
            bool isValid = false;
            while (nextBook != "No More Books")
            {
                sum++;
                if (soughtBook == nextBook)
                {
                    isValid = true;
                    break;
                }
                nextBook = Console.ReadLine();
            }
            if (!isValid)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {sum} books.");
            }
            else
                Console.WriteLine($"You checked {sum -1} books and found it.");
        }
    }
}
