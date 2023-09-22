using System;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            
            
            for (int i = 1; i <= n; i++)
            {
                string a = "";
                string b = "";
                
                for (int j = 1; j <= n; j++)
                {
                    for (int k = 1; k <= l; k++)
                    {
                        if (k == 1) { a = "a"; }
                        else if (k == 2) { a = "b"; }
                        else if (k == 3) { a = "c"; }
                        else if (k == 4) { a = "d"; }
                        else if (k == 5) { a = "e"; }
                        else if (k == 6) { a = "f"; }
                        else if (k == 7) { a = "g"; }
                        else if (k == 8) { a = "h"; }
                        else if (k == 9) { a = "i"; }
                        for (int m = 1; m <= l; m++)
                        {
                            if (m == 1) { b = "a"; }
                            else if (m== 2) { b = "b"; }
                            else if (m == 3) { b= "c"; }
                            else if (m == 4) { b = "d"; }
                            else if (m == 5) { b = "e"; }                                 
                            else if (m == 6) { b = "f"; }
                            else if (m == 7) { b = "g"; }
                            else if (m == 8) { b = "h"; }
                            else if (m == 9) { b = "i"; }
                            for (int z = 1; z <= n ; z++)
                            {
                                if (z>i && z>j)
                                Console.Write($"{i}{j}{a}{b}{z} ");               
                            }
                        }
                    }
                }
            }


        }
    }
}
