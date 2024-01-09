List<int> list= new List<int>(){1,2,3,4,5};
List<int> newList = null;
newList = CreateTList(list);
Console.WriteLine(string.Join(" ", newList));

List<int> CreateTList(List<int> list)
{
    List<int> newL = new List<int>(list.Count);
    List<int> leftList = new List<int>();
    List<int> rightList = new List<int>();

    int LeftProduct = 1;
    int RightProduct = 1;


    for (int i = 0; i < list.Count; i++)
    {
        leftList.Add (LeftProduct);
        LeftProduct *= list[i];
    }

    for (int i = list.Count - 1; i >= 0; i--)
    {
        rightList.Insert(0, RightProduct);
        RightProduct *= list[i];
    }

    for (int i = 0; i < list.Count; i++)
    {
        newL.Add(leftList[i] * rightList[i]);
    }
    return newL;
}