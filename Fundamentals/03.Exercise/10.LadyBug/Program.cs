int sizeOfField = int.Parse(Console.ReadLine());
//3
//0 1
//0 right 1
//2 right 1
//end

int[] LadyBugstInitialIndex = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();


string command = Console.ReadLine();
int[] resultArr = new int[sizeOfField];

while (command != "end")
{
    string[] arr1 = command.Split();//0 and 2 are ints and 1 is direction
    int LadyBugToMove = int.Parse(arr1[0]);
    int movementLength = int.Parse(arr1[2]);
    string direction = arr1[1];
    if (direction == "right")
    {
        LadyBugstInitialIndex[LadyBugToMove] += movementLength;
       
    }
    else if (direction == "left")
    {
        LadyBugstInitialIndex[LadyBugToMove] -= movementLength;
    }

    for (int i = 0; i < LadyBugstInitialIndex.Length; i++)
    {
        if (LadyBugstInitialIndex[LadyBugToMove] == LadyBugstInitialIndex[i])
        {
            if (direction == "right")
            {
                LadyBugstInitialIndex[LadyBugToMove] += movementLength;

            }
            else if (direction == "left")
            {
                LadyBugstInitialIndex[LadyBugToMove] -= movementLength;
            }

        }
    }

   

}
for (int i = 0; i < sizeOfField; i++) //logic for last
{
    for (int j = 0; j < LadyBugstInitialIndex.Length; j++)
    {
        if (i == LadyBugstInitialIndex[j])
        {
            resultArr[i] = 1;
        }
    }
    resultArr[i] = 0;
}
Console.WriteLine(String.Join(" ", resultArr));








