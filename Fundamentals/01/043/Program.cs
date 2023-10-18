List<string> myList = Console.ReadLine()
    .Split()
    .ToList();
string command = "";

int movesCounter = 0;
while((command=Console.ReadLine())!="end")
{
    movesCounter++;
    int[] commandArray = command.Split().Select(int.Parse).ToArray();
    int index1 = commandArray[0];
    int index2 = commandArray[1];

    if (!(index1 > -1) || !(index1 < myList.Count) || !(index2 > -1) || !(index2 < myList.Count) || index1 == index2)
    {
        Console.WriteLine("Invalid input! Adding additional elements to the board");
        string[] add = { $"-{movesCounter}a", $"-{movesCounter}a" };
        myList.InsertRange(myList.Count/2,add);
        continue;
    }
    string element1 =(myList.ElementAt(index1));
    string element2 = (myList.ElementAt(index2));
    if (element2 == element1)
    {
        Console.WriteLine($"Congrats! You have found matching elements - {element2}!");
        myList.Remove(element2);
        myList.Remove(element1);
    }
    else
    {
        Console.WriteLine("Try again!");
    }
    
    if (myList.Count == 0)
    {
        Console.WriteLine($"You have won in {movesCounter} turns!");
        return;
    }
    //add at position count/2+1
}

Console.WriteLine("Sorry you lose :(");
Console.WriteLine(string.Join(" ",myList));
