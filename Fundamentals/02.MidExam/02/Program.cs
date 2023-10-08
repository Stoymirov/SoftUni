int[] arr = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
string[] command = Console.ReadLine()
    .Split()
    .ToArray();
string commandWord = command[0];
while (commandWord != "end")
{
    if (commandWord =="decrease")
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] -= 1;
        }
    }

    else if (commandWord == "swap")
    {
        int index1 = int.Parse(command[1]);
        int index2 = int.Parse(command[2]);
        int a = arr[index1];
        int b = arr[index2];
        arr[index1] = b;
        arr[index2] = a;
    }
    else if (commandWord == "multiply")
    {
        int index1 = int.Parse(command[1]);
        int index2 = int.Parse(command[2]);

        arr[index1] = arr[index1] * arr[index2];
    }
     command = Console.ReadLine()
    .Split()
    .ToArray();
     commandWord = command[0];
}
Console.WriteLine(string.Join(", ", arr));