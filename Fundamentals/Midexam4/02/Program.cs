using System.Collections.Generic;

List<string> myList = Console.ReadLine()
    .Split("!")
    .ToList();
string command = "";
while((command = Console.ReadLine()) != "Go Shopping!")
{
    string[] commandArray = command
        .Split()
        .ToArray();
    if (commandArray[0] == "Urgent")
    {
        UrgentMethod(commandArray, myList);
    }
    else if (commandArray[0] == "Unnecessary")
    {
        Unnecessary(commandArray, myList);
    }
    else if (commandArray[0] == "Correct")
    {
        CorrenctMethod(commandArray, myList);
    }
    else if (commandArray[0] == "Rearrange")
    {
        RearrangeMethod(commandArray, myList);
    }
}

Console.WriteLine(string.Join(", ",myList));
void UrgentMethod(string[] strings, List<string> list)
{
    string itemToAdd = strings[1];
    if (list.Contains(itemToAdd))
    {
        return;
    }
    else
    {
        list.Insert(0, itemToAdd);
    }
}

void Unnecessary(string[] commandArray1, List<string> myList1)
{
    string itemToAdd = commandArray1[1];
    if (myList1.Contains(itemToAdd))
    {
        myList1.Remove(itemToAdd);
    }
}

void CorrenctMethod(string[] strings1, List<string> list1)
{
    string oldItem = strings1[1];
    string newItem = strings1[2];
    int indexOfOldItem = list1.IndexOf(oldItem);
    if (list1.Contains(oldItem))
    {
        list1[indexOfOldItem] = newItem;
    }
}

void RearrangeMethod(string[] commandArray2, List<string> myList2)
{
    string item = commandArray2[1];
    if (myList2.Contains(item))
    {
        myList2.Add(item);
        myList2.Remove(item);
    }
}