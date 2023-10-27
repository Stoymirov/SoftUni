using System.Data;

List<string> myList = Console.ReadLine()
    .Split(", ")
    .ToList();

int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] command = Console.ReadLine()
        .Split(", ")
        .ToArray();

    if (command[0] == "Add")
    {
        AddMethod(myList, command);
    }
    else if (command[0] == "Remove")
    {
        RemoveMethod(myList, command);
    }
    else if (command[0] == "Remove At")
    {
        RemoveAtMethod(command, myList);
    }
    else if (command[0] == "Insert")
    {
        InsertMethod(command, myList);
    }
}

Console.WriteLine(string.Join(", ",myList));

void AddMethod(List<string> list, string[] strings)
{
    if (list.Contains(strings[1]))
    {
        Console.WriteLine("Card is already in the deck");
    }
    else
    {
        list.Add(strings[1]);
        Console.WriteLine("Card successfully added");
    }
}

void RemoveMethod(List<string> myList1, string[] command1)
{
    if (!myList1.Contains(command1[1]))
    {
        Console.WriteLine("Card not found");
    }
    else
    {
        myList1.Remove(command1[1]);
        Console.WriteLine("Card successfully removed");
    }
}

void RemoveAtMethod(string[] strings1, List<string> list1)
{
    if (int.Parse(strings1[1]) < 0 || int.Parse(strings1[1]) >= list1.Count)
    {
        Console.WriteLine("Index out of range");
    }
    else
    {
        list1.RemoveAt(int.Parse(strings1[1]));
        Console.WriteLine("Card successfully removed");
    }
}

void InsertMethod(string[] command2, List<string> myList2)
{
    if (int.Parse(command2[1]) < 0 || int.Parse(command2[1]) >= myList2.Count)
    {
        Console.WriteLine("Index out of range");
    }
    else
    {
        if (myList2.Contains(command2[2]))
        {
            Console.WriteLine("Card is already added");
        }
        else
        {
            myList2.Insert(int.Parse(command2[1]), command2[2]);
            Console.WriteLine("Card successfully added");
        }
    }
}
