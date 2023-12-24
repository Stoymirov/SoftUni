int[] numbers = { 2, 3, 1, 3 };

int[] myArray = Where(numbers, (x) => x % 2 == 0);

int[] Where(int[] array, Func<int, bool> filter)
{
    List<int> list = new List<int>();
    foreach (var i in array)
    {
        if(filter(i)) list.Add(i);
    }

    return list.ToArray();

}

Console.WriteLine(string.Join(" ",myArray));