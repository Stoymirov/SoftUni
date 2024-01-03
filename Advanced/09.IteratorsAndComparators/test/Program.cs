



//using System.Collections;

//class EnumeratorList : IEnumerable<int>
//{

//    private List<int> list;
//    private int index = 0;
//    public EnumeratorList(List<int> list)
//    {
//        this.list = list;
//    }

//    public int Current => list[index];

//    public bool MoveNext()
//    {
//        index++;
//        if (index == list.Count)
//            return false;
//        return true;
//    }


//    public IEnumerator<int> GetEnumerator()
//    {
        
//    }

//    IEnumerator IEnumerable.GetEnumerator()
//    {
//        return GetEnumerator();
//    }

//    public void Dispose()
//    {

//    }
//}
