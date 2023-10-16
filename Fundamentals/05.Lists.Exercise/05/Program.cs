List<int> myList = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int number = numbers[0];
int power = numbers[1];
while (myList.Contains(number))
{
    int index = myList.IndexOf(number);

    int leftIndex = Math.Max(0, index - power);
    int rightIndex = Math.Min(myList.Count - 1, index +power);

    int range = rightIndex - leftIndex+1;

    myList.RemoveRange(leftIndex,range);
}

Console.WriteLine(myList.Sum());
