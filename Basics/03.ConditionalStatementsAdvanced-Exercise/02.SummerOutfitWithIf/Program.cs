using System;

namespace _02.SummerOutfitWithIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int celcius = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            string outfit = "";
            string shoes = "";
            if (celcius >= 10 && celcius <= 18)
            {
                if (timeOfDay == "Morining")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (timeOfDay == "Evening" || timeOfDay == "Afternoon")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (celcius > 18 && celcius <= 24)
            {
               if(timeOfDay == "Morning" || timeOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
               else if ( timeOfDay == "Afternoon")
                {
                    outfit = "T-Shirt";
                        shoes = "Sandals";
                }
            }
            else if (celcius >= 25)
            {
                if (timeOfDay == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (timeOfDay == "Afternoon")
                {
                    outfit = "Swim suit";
                    shoes = "Barefoot";
                }
                else if (timeOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";

                }
                
                
            }
        }

    }
}


