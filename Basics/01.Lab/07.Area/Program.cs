using System;

namespace _07.Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = (Console.ReadLine());
            if (input == "square")
                {
                double inputSquare = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f3}", inputSquare * inputSquare);
            }
            else if (input == "rectangle")
            {
                double inputRectangle1 = double.Parse(Console.ReadLine());
                double inputRectangle2 = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f3}", inputRectangle1 * inputRectangle2);
            }
            else if (input == "circle")
            {
                double inputCircle = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f3}", inputCircle * Math.PI * inputCircle);
            }
            else if (input == "triangle")
            {
                double inputTriangle1 = double.Parse(Console.ReadLine());
                double inputTriangle2 = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f3}", inputTriangle2 * inputTriangle1 / 2.00);
            }
            

            
        }
    }
}
