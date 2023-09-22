using System;

namespace _03._Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //find when a number is prime
            //if the number devided by a number that is below the square root of the first number gives % 0 it is not price.
            int notPRime = 0;
            int prime = 0;


            string input = Console.ReadLine();
            while (input != "stop")
            {
                int number = int.Parse(input);


                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    bool isPrime = true;
                    if (number < 2)
                    { isPrime = false;}
                    else
                    {
                        double sqrt = Math.Sqrt(number);
                        for (int i = 2; i <= sqrt; i++)
                        {


                            if (number % i == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                    }
                    if (isPrime)
                    {
                        prime += number;
                    }
                    else if (!isPrime)
                    {
                        notPRime += number;
                    }
                }
                input = Console.ReadLine();

            }
            Console.WriteLine($"Sum of all prime numbers is: {prime}");
            Console.WriteLine($"Sum of all non prime numbers is: {notPRime}");
        }
    }

}
