using System.Collections;

List<int> numbers = new List<int>(){1,2,3,4,5,6};
//EnumeratorList enumerator = new EnumeratorList(numbers);
//do
//{
//    Console.WriteLine(enumerator.Current);
//} while(enumerator.MoveNext());
//enumerator.Reset();

SoftUniList list = new SoftUniList(numbers);
foreach (var VARIABLE in numbers)
{
    Console.WriteLine(VARIABLE);
}

IEnumerator<int> enumerator = list.GetEnumerator();
while (enumerator.MoveNext())
{
    Console.WriteLine(enumerator.Current);
}


class SoftUniList : IEnumerable<int>
{
    private List<int> list;
    private int index = 0;
    public SoftUniList(List<int> list)
    {
        this.list = list;
    }

    public IEnumerator<int> GetEnumerator()
    {
        return new EnumeratorList(list);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

class EnumeratorList : IEnumerator<int>
{

    private List<int> list;
    private int index = -1;
    public EnumeratorList(List<int> list)
    {
        this.list = list;
    }

    public void Reset()
    {
        index = 0;
    }

    object IEnumerator.Current => Current;

    public int Current => list[index];

    public bool MoveNext()
    {
        index++;
        if (index == list.Count)
            return false;
        return true;
    }
   

    public void Dispose()
    {

    }
}