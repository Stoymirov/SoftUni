using System.ComponentModel.DataAnnotations;

int[] arr = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
string[] command = new string[0];
while ((command = Console.ReadLine()
        .Split()
        .ToArray())[0] != "end")
{
    if (command[0] == "exchange")
    {
        int index = int.Parse(command[1]);
        if (index > arr.Length - 1)
        {
            Console.WriteLine("Invalid index");
            continue;
        }
        arr = ExchangeMethod(arr, index);

    }
    else if (command[0] == "max")
    {
        MethodForMax(arr, command);

    }
    else if ((command[0] == "first"))
    {
        int numberOfElements = int.Parse(command[1]);
        string evenOrOdd = command[2];
        MethodForFirst(arr, numberOfElements, evenOrOdd);

    }
    else if ((command[0] == "last"))
    {
        int numberOfElements = int.Parse(command[1]);
        string evenOrOdd = command[2];
        MethodForSecond(arr, numberOfElements, evenOrOdd);
    }
    else MethodForMin(arr, command);


}
Console.WriteLine($"[{string.Join(", ", arr)}]");

static void MethodForFirst(int[] arr, int numberOfElements, string evenOrOdd)
{
    int counter = 0;
    int[] arrayOfNumbers = new int[numberOfElements];
    if (numberOfElements >= arr.Length || numberOfElements < 0)
    {
        Console.WriteLine("Invalid count");
        return;
    }
    for (int i = 0; i < arr.Length; i++)
    {

        if (evenOrOdd == "even")
        {
            if (arr[i] % 2 == 0)
            {

                counter++;
                arrayOfNumbers[counter - 1] = arr[i];
            }
        }
        else
        {
            if (arr[i] % 2 == 1)
            {
                counter++;
                arrayOfNumbers[counter - 1] = arr[i];
            }
        }
        if (counter == numberOfElements)
        {
            Console.WriteLine($"[{string.Join(", ", arrayOfNumbers)}]");
            break;
        }

    }
    int[] arrayForSecondCase = new int[counter];
    for (int i = 0; i < counter; i++)
    {
        arrayForSecondCase[i] = arrayOfNumbers[i];
    }
    if (counter != numberOfElements)
        Console.WriteLine($"[{string.Join(", ", arrayForSecondCase)}]");
}

static void MethodForSecond(int[] arr, int numberOfElements, string evenOrOdd)
{
    int counter = 0;
    int[] arrayOfNumbers = new int[numberOfElements];
    for (int i = arr.Length - 1; i >= 0; i--)
    {

        if (evenOrOdd == "even")
        {
            if (arr[i] % 2 == 0)
            {

                counter++;
                arrayOfNumbers[counter - 1] = arr[i];
            }
        }
        else
        {
            if (arr[i] % 2 == 1)
            {
                counter++;
                arrayOfNumbers[counter - 1] = arr[i];
            }
        }
        if (counter == numberOfElements)
        {
            Console.WriteLine($"[{string.Join(", ", arrayOfNumbers)}]");
            break;
        }
    }
    int[] arrayForSecondCase = new int[counter];
    for (int i = 0; i < counter; i++)
    {
        arrayForSecondCase[i] = arrayOfNumbers[i];
    }
    if (counter != numberOfElements)
        Console.WriteLine($"[{string.Join(", ", arrayForSecondCase)}]");
}

static int[] ExchangeMethod(int[] arr, int index)
{
    int[] changedArr = new int[arr.Length];
    int counter = 0;
    for (int i = index + 1; i < arr.Length; i++)
    {
        changedArr[counter] = arr[i];
        counter++;
    }
    for (int i = 0; i <= index; i++)
    {
        changedArr[counter] = arr[i];
        counter++;
    }
    return changedArr;
}

static void MethodForMax(int[] arr, string[] command)
{
    int MaxIndex = -1;
    int maxNumber = int.MinValue;

    for (int i = 0; i < arr.Length; i++)
    {
        if (command[1] == "even" && arr[i] % 2 == 0 ||
            command[1] == "odd" && arr[i] % 2 != 0)
        {
            if (arr[i] >= maxNumber)
            {
                maxNumber = arr[i];
                MaxIndex = i;
            }
        }

    }
    if (MaxIndex > -1)
        Console.WriteLine(MaxIndex);
    else Console.WriteLine("No matches");
}

static void MethodForMin(int[] arr, string[] command)
{
    if (command[0] == "min")
    {
        int minIndex = -1;
        int minNumber = int.MaxValue;

        for (int i = 0; i < arr.Length; i++)
        {
            if (command[1] == "even" && arr[i] % 2 == 0 ||
                command[1] == "odd" && arr[i] % 2 != 0)
            {
                if (arr[i] <= minNumber)
                {
                    minNumber = arr[i];
                    minIndex = i;
                }
            }

        }
        if (minIndex > -1)
            Console.WriteLine(minIndex);
        else Console.WriteLine("No matches");
    }
    
}