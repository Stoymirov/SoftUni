int shotTargetsCounter = 0;

List<int> myList = Console.ReadLine()
    .Split()
   .Select(int.Parse)
   .ToList();

string command = "";
while ((command = Console.ReadLine()) != "End")
{
    int indexTarget = int.Parse(command);
    if(indexTarget <0 ||indexTarget >= myList.Count)
    {
        continue;
    }
    int TargetUnchanged = myList[indexTarget];
    if (myList[indexTarget] != -1)
    {
        myList[indexTarget] = -1;
        shotTargetsCounter++;
        for (int i = 0; i < myList.Count; i++)
        {
            if (myList[i] !=-1)
            {
                if (myList[i] > TargetUnchanged)
                {
                    myList[i] -= TargetUnchanged;
                }
                else if (myList[i] <= TargetUnchanged)
                {
                    myList[i] += TargetUnchanged;
                }
            }
        }
    }
}
Console.WriteLine($"Shot targets: {shotTargetsCounter} -> {(string.Join(" ",myList))}");