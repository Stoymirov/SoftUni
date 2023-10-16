int numberOfComands = int.Parse(Console.ReadLine());

List<string> names = new List<string>();
for (int i = 0; i < numberOfComands; i++)
{
    string input = Console.ReadLine();

    string[] inputArray = input.Split()
        .ToArray();
    if (inputArray[2] != "not")
    {
        if (names.Contains(inputArray[0]))
        {
            Console.WriteLine($"{inputArray[0]} is already in the list!");
        }
        else
        {
            names.Add(inputArray[0]);
        }
    }
    else
    {
        if (!names.Exists(x=>x == inputArray[0]))
        {
            Console.WriteLine($"{inputArray[0]} is not in the list!");
        }
        else
        {
            names.Remove(inputArray[0]);
        }
    }
}

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}