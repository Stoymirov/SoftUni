int fieldSize = int.Parse(Console.ReadLine());

int[] LadyBugsInitialIndex = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] fieldArray = new int[fieldSize];

for (int i = 0; i < fieldSize; i++)
{
    fieldArray[i] = 0;
    for (int j = 0; j < LadyBugsInitialIndex.Length; j++)
    {
        if (LadyBugsInitialIndex[j] == i)
        {
            fieldArray[i] = 1;
        }

    }
}
// second option

//for (int i = 0; i < LadyBugsInitialIndex.Length; i ++)
//{
//    if (LadyBugsInitialIndex[i] < 0 || LadyBugsInitialIndex[i] >=fieldSize)
//    {
//        continue;
//    }
//    else
//    {
//        fieldArray[LadyBugsInitialIndex[i]] = 1;
//    }
//}
string command = "";
while ((command = Console.ReadLine()) != "end")
{
    string[] commandToElements = command
        .Split();
    int indexOfBugToMove = int.Parse(commandToElements[0]);
    int FlightRange = int.Parse(commandToElements[2]);
    string direction = commandToElements[1];
    int number = indexOfBugToMove + FlightRange;
    int negativeNumber = indexOfBugToMove - FlightRange;

    switch (direction)
    {

        case "right":
            if (indexOfBugToMove >= fieldSize || indexOfBugToMove < 0 || fieldArray[indexOfBugToMove] == 0)
            {
                continue;
            }


            fieldArray[indexOfBugToMove] = 0;
            if (number >= fieldSize)
            {
                continue;
            }
            if (fieldArray[number] != 1 && number < fieldSize)
            {
                fieldArray[number] = 1;
            }
            else if (number == 1)
            {
                while (number == 1)
                {
                    number += FlightRange;
                    if (number >= fieldSize)
                    {
                        break;
                    }
                }
                if (number >= fieldSize)
                {
                    continue;
                }
                fieldArray[number] = 1;
            }
            break;


        case "left":
            if (indexOfBugToMove >= fieldSize || indexOfBugToMove < 0 || fieldArray[indexOfBugToMove] == 0)
            {
                continue;
            }

            fieldArray[indexOfBugToMove] = 0;
            if (negativeNumber < 0)
            {
                continue;
            }
            if (fieldArray[negativeNumber] != 1 && negativeNumber >= 0)
            {
                fieldArray[negativeNumber] = 1;
            }
            else if (negativeNumber == 1)
            {
                while (negativeNumber == 1)
                {
                    negativeNumber -= FlightRange;
                    if (negativeNumber < 0)
                    {
                        break;
                    }
                }
                if (negativeNumber < 0)
                {
                    continue;
                }
                fieldArray[negativeNumber] = 1;
            }
            break;
    }
}
Console.WriteLine(string.Join(" ", fieldArray));