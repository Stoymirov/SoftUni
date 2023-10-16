List<int> myList = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

string command = "";
while ((command = Console.ReadLine()) != "End")
{
    string[] commandArray = command.Split().ToArray();

    if (commandArray[0] == "Add")
    {
        
        myList.Add(int.Parse(commandArray[1]));
    }
    else if (commandArray[0] == "Insert")
    {
        if (int.Parse(commandArray[2]) > myList.Count - 1 || int.Parse(commandArray[2])<0)
        {
            Console.WriteLine("Invalid index");
            continue;
        }

        myList.Insert(int.Parse(commandArray[2]), int.Parse(commandArray[1]));
    }
    else if (commandArray[0] == "Remove")
    {
        if (int.Parse(commandArray[1]) > myList.Count - 1 || int.Parse(commandArray[1]) < 0)
        {
            Console.WriteLine("Invalid index");
            continue;
        }
        myList.RemoveAt(int.Parse(commandArray[1]));
    }
    else if (commandArray[1] == "left")
    {

        for (int i = 0; i < int.Parse(commandArray[2]); i++)
        {
            myList.Add(myList[0]);
            myList.RemoveAt(0);
        }

    }
    else if (commandArray[1] == "right")
    {
        for (int i = 0; i < int.Parse(commandArray[2]); i++)
        {
            myList.Insert(0, myList[^1]);//last element
            myList.RemoveAt(myList.Count - 1);
        }
    }

   
}

Console.WriteLine(string.Join(" ",myList));
