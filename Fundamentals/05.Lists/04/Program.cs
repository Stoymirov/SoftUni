int n = int.Parse(Console.ReadLine());
List<string> myList = new List<string>();
for (int i = 0; i < n; i++)
{
    myList.Add(Console.ReadLine());
}
myList.Sort();
for (int i = 1; i <= myList.Count; i++)
{
    Console.WriteLine($"{i}.{myList[i-1]}");
}

static List<string> ReadIntList()
{
    return Console.ReadLine()
        .Split().ToList();
        
}