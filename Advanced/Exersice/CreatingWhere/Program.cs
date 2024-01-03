int[] array = new int[] {1,2,3,4,5,6,12};

int[] newarray = Where(array, x => x % 2 == 0);

foreach (var i in newarray)
{
    Console.WriteLine(i);
}
static int[] Where(int[] array,Predicate<int> filter)
{
    List<int> list = new List<int>();
    foreach (var VARIABLE in array)
    {
        if (filter(VARIABLE))
        {
            list.Add(VARIABLE);
        }
    }
    return list.ToArray();
}