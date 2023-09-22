using System;

namespace _06._Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfFloors = int.Parse(Console.ReadLine());
            int RoomsPerFloor = int.Parse(Console.ReadLine());
            for (int floor = numberOfFloors; floor >= 1; floor--)
            {
                for (int room = 0; room < RoomsPerFloor; room++)
                {
                    if (numberOfFloors == floor)
                    {
                        Console.Write($"L{floor}{room} ");
                    }
                    else if (floor % 2 ==0)
                    {
                        Console.Write($"O{floor}{room} ");
                    }
                    else if (floor % 2 != 0)
                    {
                        Console.Write($"A{floor}{room} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

}
