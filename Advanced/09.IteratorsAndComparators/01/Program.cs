using System.Collections;

SoftUniList list  = new SoftUniList();
foreach (var item in list)
{
    Console.WriteLine(item);
}



class SoftUniList : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator()
    {
        return null;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}