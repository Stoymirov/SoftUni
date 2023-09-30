long fieldSize = int.Parse(Console.ReadLine());

int[] BugInitialIndex = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] fieldSizeArr = new int[fieldSize];

for (int i = 0; i < BugInitialIndex.Length; i++)
{
    if (BugInitialIndex[i] < 0 || BugInitialIndex[i] >= fieldSize)// if it is outside of the given field
    {
        continue;
    }
    else { fieldSizeArr[BugInitialIndex[i]] = 1; }

}

string command = "";
while ((command = Console.ReadLine()) != "end")
{
    string[] splitedCommand = command.Split();
    int BugIndex = int.Parse(splitedCommand[0]);
    string direction = (splitedCommand[1]);
    int flightLength = int.Parse(splitedCommand[2]);

    if (BugIndex >= fieldSize || BugIndex < 0 || fieldSizeArr[BugIndex] == 0)
    {
        continue;
    }
    int landIndex; 
    fieldSizeArr[BugIndex] = 0;
    switch (direction)
    {
        case "right":

            landIndex = BugIndex + flightLength;

            if (landIndex >= fieldSize)
            {
                continue;
            }
            else
            {
                while (fieldSizeArr[landIndex] == 1)
                {
                    landIndex += flightLength;
                    if (landIndex >= fieldSize)
                    {
                        break;
                        
                    }
                }
            }
            if (landIndex < 0 || landIndex >= fieldSize)
            {
                continue;
            }
            else fieldSizeArr[landIndex] = 1;

            break;

        case "left":
            landIndex = BugIndex - flightLength;
            if (landIndex < 0)
            {
                continue;
            }
            else 
            {
                while (fieldSizeArr[landIndex] == 1 )
                {
                    landIndex -= flightLength;
                    if (landIndex < 0)
                    {
                        break;
                    }
                }
            }
            if (landIndex < 0 || landIndex >= fieldSize)
            {
                continue;
            }
            else fieldSizeArr[landIndex] = 1;

            break;
    }
}
Console.WriteLine(string.Join(" ", fieldSizeArr));


//1. the massive for bug index is needed only to find out on which places in teh massive for answer to place 1 and 0 and you work with the field massive
