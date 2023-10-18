
List<int> myList = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

string command = "";
while ((command = Console.ReadLine()) != "End")
{
    string[] commandArray = command.Split().ToArray();

    switch (commandArray[0])
    {
        case "Shoot":

            SwitchMethod(commandArray, myList);
            break;
        case "Add":

            AddMethod(commandArray, myList);
            break;
        case "Strike":

            StrikeMethod(commandArray, myList);
            break;
    }
}

Console.WriteLine(string.Join("|", myList));

void SwitchMethod(string[] commandArray, List<int> myList)
{

    int index = int.Parse(commandArray[1]);
    int power = int.Parse(commandArray[2]);
    if (index < 0 || index > myList.Count - 1)
    {
        return;
    }
    myList[index] -=power;
    if (myList[index] <= 0)
    {
        myList.RemoveAt(index);
    }
    return;
}

void AddMethod(string[] commandArray, List<int> myList)
{
    int index = int.Parse(commandArray[1]);
    int value = int.Parse(commandArray[2]);
    if (index < 0 || index > myList.Count - 1)
    {
        Console.WriteLine("Invalid placement!");
        return;
    }
    myList.Insert(index, value);
    return;
}

void StrikeMethod(string[] commandArray, List<int> myList)
{
    int index = int.Parse(commandArray[1]); 
    int radius = int.Parse(commandArray[2]);
    if (index-radius < 0 || index+radius > myList.Count - 1)
    {
        Console.WriteLine("Strike missed!");
        return;
    }

    int range = 2 * radius + 1;
    int startOfRemoval = index - radius;
    myList.RemoveRange(startOfRemoval,range);
    return;
}
