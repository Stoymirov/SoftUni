int[] array = {1,2,-1,3,-7,-6,-2,14,64};
int index = 0;
for (int i = 0; i<array.Length; i++)
{
    if (array[i] >= 0)
    {
        array[index] = array[i];
        index++;
    }
}
Array.Resize(ref array, index);
Console.WriteLine(string.Join(" ", array));