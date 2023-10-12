List<int> myList = ReadIntList();


string[] command = Console.ReadLine()
        .Split()
        .ToArray();

while (command[0]  != "end")
{
    switch (command[0])
    {
        case "Add":
            myList.Add(int.Parse(command[1]));
            break;
        case "Remove":
            myList.Remove(int.Parse(command[1]));
            break;
        case "RemoveAt":
            myList.RemoveAt(int.Parse(command[1]));
            break;
        case "Insert":
            myList.Insert(int.Parse(command[2]), int.Parse(command[1]));
            break;

                
    }
    command = Console.ReadLine()
        .Split()
        .ToArray();
}
Console.WriteLine(string.Join(" ",myList));








static List<int> ReadIntList()
{
    return Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToList();
}