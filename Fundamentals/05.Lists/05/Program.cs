List<int> myList = ReadIntList();

for (int i = 0; i < myList.Count; i++)
{
    if (myList[i] <0)
    {
        myList.Remove(myList[i]);
        i--;
    }
}
myList.Reverse();
if(myList.Count == 0)
{
    Console.WriteLine("empty");
}
else
Console.WriteLine(string.Join(" ",myList));






static List<int> ReadIntList()
{
    return Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToList();
}