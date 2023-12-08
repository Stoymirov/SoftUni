using System.ComponentModel.Design;

int[] input = Console.ReadLine()
    .Split()
        .Select(int.Parse)
    .ToArray(); //5 4 8 6 3 8 7 7 9

Stack<int> racks = new Stack<int>(input);

int capacity = int.Parse(Console.ReadLine());
int currentCapacity = 0;
int total = 1;
while (racks.Count > 0)
{
    int currentValue = racks.Pop();

    if (currentValue + currentCapacity <= capacity)
    {
        currentCapacity += currentValue;
    }
    else
    {
        currentCapacity = currentValue;
        total++;

    }
}
Console.WriteLine(total);