//double for cycle the first is arr1[1], the second goes from arr1[1..] and checks if anything is common. A third array stores all the common things
string[] arr1 = Console.ReadLine()
    .Split()
    .ToArray();

string[] arr2 = Console.ReadLine()
    .Split()
    .ToArray();


int numberOfCommonElements = 0;
for (int i = 0; i < arr1.Length; i++)
{
    for (int j = 0; j < arr2.Length; j++)
    {
        if (arr1[i] == arr2[j])
        {
            numberOfCommonElements++;
        }
    }
}

string[] arr3 = new string[numberOfCommonElements];
int counterOfPlace = 0;
for (int i = 0; i < arr1.Length; i++)
{
    for (int j = 0; j < arr2.Length; j++)
    {
        if (arr1[i] == arr2[j])
        {
            arr3[counterOfPlace] = arr1[i];
            counterOfPlace++;
        }
    }
}
Console.WriteLine(string.Join(" ", arr3));