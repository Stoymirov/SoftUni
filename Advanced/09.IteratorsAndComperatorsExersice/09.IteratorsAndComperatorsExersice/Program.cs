

using System.Collections;

Stadium stadium = new(new List<int>(){1,2,3});
//foreach (var seat in stadium)
//{
//    Console.WriteLine(seat);
//}
StadiumEnumerator enumerator = new(new List<int>(){1,2,3});
while (enumerator.MoveNext())
{
    Console.WriteLine(enumerator.Current);
}
public class Stadium:IEnumerable<int>
{
    private List<int> _seats;
    public Stadium(List<int> seats) 
    {
        _seats = seats;
    }

    public IEnumerator<int> GetEnumerator()
    {
        StadiumEnumerator enumerator = new(_seats);
        return enumerator;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

}

class StadiumEnumerator:IEnumerator<int>
{
    private List<int> _seats;
    private int index = -1;

    public StadiumEnumerator(List<int> seats)
    {
        _seats = seats;
    }

    public void Dispose()
    {
        // TODO release managed resources here
    }

    public bool MoveNext()
    {
        index++;
        return index < _seats.Count;
    }

    public void Reset()
    {
        index = -1;
    }

    public int Current
    {
        get { return _seats[index]; }
    }

    object IEnumerator.Current => Current;
}