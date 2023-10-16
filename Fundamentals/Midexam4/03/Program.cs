using System.Transactions;

List<int> myList = Console.ReadLine()
    .Split("@")
    .Select(int.Parse)
    .ToList();
string command = "";
int currentCupidPosition = 0;
while ((command = Console.ReadLine()) != "Love!")
{
    string[] commandArray = command.Split().ToArray();

    int jumpLength = int.Parse(commandArray[1]);
    if (currentCupidPosition+jumpLength > myList.Count - 1)
    {
        currentCupidPosition = 0;
    }
    else
    {
        currentCupidPosition += jumpLength;
    }

    if (myList[currentCupidPosition] != 0)
    {
    myList[currentCupidPosition] -= 2;
    if (myList[currentCupidPosition] == 0)
    {
        Console.WriteLine($"Place {currentCupidPosition} has Valentine's day.");
    }
    }
    else
    {
        Console.WriteLine($"Place {currentCupidPosition} already had Valentine's day.");
    }
    

}

Console.WriteLine($"Cupid's last position was {currentCupidPosition}.");
int counter = 0;
int index = -2;
while (index != -1)
{
    index = myList.FindIndex(x => x > 0);
    if (index >=0) {myList.RemoveAt(index); counter++; }
   
}

if (counter == 0)
{
    Console.WriteLine("Mission was successful.");
}
else
{
    Console.WriteLine($"Cupid has failed {counter} places.");
}
        