using System;

List<int> myList = ReadIntList();
List<int> myListCopy = myList;
string[] command = Console.ReadLine()
        .Split()
        .ToArray();
while (command[0] != "end")
{
    switch (command[0])
    {
        case "Contains":
            bool real = myList.Contains(int.Parse(command[1]));
            if (real)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
            break;
        case "PrintEven":
            List<int> evenNumbers = myList.Where(n => n % 2 == 0).ToList();
            Console.WriteLine(string.Join(" ", evenNumbers));
            break;
        case "PrintOdd":
            List<int> oddNumber = myList.Where(n => n % 2 != 0).ToList();
            Console.WriteLine(string.Join(" ", oddNumber));
            break;
        case "GetSum":

            Console.WriteLine(myList.Sum());
            break;
        case "Filter":
            Console.WriteLine(string.Join(" ", Filter(myList, command[1], int.Parse(command[2]))));
            break;

    }
    command = Console.ReadLine()
        .Split()
        .ToArray();
}
if (myList != myListCopy)
{
    Console.WriteLine(myList);
}
static List<int> Filter(List<int> myList, string command, int number)
{
    List<int> result = new List<int>();
    foreach (int i in myList)
        if (command == "<" && i < number)
        {
            result.Add(i);
        }
        else if (command == ">" && i > number)
        {
            result.Add(i);
        }
        else if (command == "<=" && i <= number)
        {
            result.Add(i);
        }
        else if (command == ">=" && i >= number)
        {
            result.Add(i);
        }
    return result;
}
static List<int> ReadIntList()
{
    return Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToList();
}