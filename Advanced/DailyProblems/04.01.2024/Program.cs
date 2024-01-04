//using System.Xml.Serialization;

List<int> ints = new List<int>()
{
    2,5,10,7,8
};
int k = 20;

//bool found = false;
//for (int i = 0; i < ints.Count-1; i++)
//{
//    for (int j = i+1; j < ints.Count; j++)
//    {
//        if (ints[i] + ints[j] == k)
//        {
//            found = true;
//        }
//    }
//}
//Console.WriteLine(found);

//bool foundSecond = false;

//foreach (var i in ints)
//{
//    if (ints.Exists(x => k - x == i &&x!=i))
//    {
//        foundSecond = true;
//    }
//}

//Console.WriteLine(foundSecond);

static Tuple<int,int> FindNumbers(List<int> list,int k) 
{
    HashSet<int> hs = new HashSet<int>();
    for (int i = 0; i < list.Count; i++)
    {
        if (hs.Contains(k - list[i]))
        {
            return Tuple.Create(list.IndexOf(k - list[i]), i);
        }
        hs.Add(list[i]);
    }

    return null;
}