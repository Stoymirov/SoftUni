using System;
using System.Globalization;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialOfFirstPair = int.Parse(Console.ReadLine());
            int initialOfSecondPair = int.Parse(Console.ReadLine());
            int DifferenceOfFirstPair = int.Parse(Console.ReadLine());
            int DifferenceOfSecondPair = int.Parse(Console.ReadLine());
            int maxFirstPAir = initialOfFirstPair + DifferenceOfFirstPair;
            int maxSecondPair = initialOfSecondPair + DifferenceOfSecondPair;
            
            for (int i = initialOfFirstPair; i <= maxFirstPAir; i++)
            {
                bool forI = true;
                
                for (int j = initialOfSecondPair; j <= maxSecondPair; j++)
                {
                    bool forJ = true;
                    
                    for (int k = 2; k < i; k++) 
                    {
                        if (i%k==0)
                        {
                            forI= false;
                            break;
                        }
                    }
                    

                    for (int l = 2; l < j; l++)
                    {
                        if (j % l == 0)
                        {
                            forJ = false;
                            break;
                        }
                    }
                    if (forJ == true && forI == true)
                    {
                        Console.WriteLine($"{i}{j}");
                        
                    }
                }
                   
            }
        }
    }
}
