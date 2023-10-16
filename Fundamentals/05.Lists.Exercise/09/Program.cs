List<int> myList = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

int sumOfElements = 0;
while (myList.Count > 0)
{
    int index = int.Parse(Console.ReadLine());
    if (index < 0)
    {
        int lastElement = myList[myList.Count - 1];
        int removedElement = myList[0];
        sumOfElements += removedElement;
        myList.RemoveAt(0);
        myList.Insert(0,lastElement);

       myList = ChanidingValuesInList(myList, removedElement);
    }
    else if (index > myList.Count - 1)
    {
        int firstElement = myList[0];
        int removedElement = myList[myList.Count - 1];
        sumOfElements += removedElement;
        myList.RemoveAt(myList.Count-1);
        myList.Add(firstElement);

        myList = ChanidingValuesInList(myList, removedElement);
    }
    else
    {
        int removedElement = myList[index];
        sumOfElements += removedElement;
        myList.RemoveAt(index);


        myList = ChanidingValuesInList(myList, removedElement);
    }

}

Console.WriteLine(sumOfElements);

static List<int> ChanidingValuesInList(List<int> list, int removedElement1)
{
    for (int i = 0; i < list.Count; i++)
    {
        if (list[i] <= removedElement1)
        {
            list[i] += removedElement1;
        }
        else if (list[i] > removedElement1)
        {
            list[i] -= removedElement1;
        }
    }
    return list;
}

