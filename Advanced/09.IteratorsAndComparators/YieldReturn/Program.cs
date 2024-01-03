using System.Collections;

foreach (var item in new SoftUniList())
{

}
class SoftUniList:IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0;i<100;i++)
        {
            yield return i;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}