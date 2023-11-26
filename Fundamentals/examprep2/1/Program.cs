string activationKey = Console.ReadLine();

string command = "";
while ((command = Console.ReadLine()) != "Generate")
{
    string[] array = command.Split(">>>").ToArray();
    switch (array[0])
    {
        case ("Contains"):
            ContainsFunction(activationKey, array);
            break;
        case ("Flip"):
            if (array[1] == "Upper")
            {
                activationKey = UpperFunction(activationKey, array);
            }
            else
            {
                activationKey = LowerFunction(activationKey, array);
            }
            break;
        case ("Slice"):
            activationKey = SliceFunction(activationKey, array);
            break;
    }
}

Console.WriteLine($"Your activation key is: {activationKey}");

string UpperFunction(string? s, string[] strings)
{
    string substring = s.Substring(int.Parse(strings[2]), int.Parse(strings[3]) - int.Parse(strings[2]));
    string substringNew = substring.ToUpper();
    s = s.Replace(substring, substringNew);
    Console.WriteLine(s);
    return s;
}

string LowerFunction(string? activationKey1, string[] array1)
{
    string substring = activationKey1.Substring(int.Parse(array1[2]), int.Parse(array1[3]) - int.Parse(array1[2]));
    string substringNew = substring.ToLower();
    activationKey1 = activationKey1.Replace(substring, substringNew);
    Console.WriteLine(activationKey1);
    return activationKey1;
}

string SliceFunction(string? s1, string[] strings1)
{
    s1 = s1.Remove(int.Parse(strings1[1]), int.Parse(strings1[2]) - int.Parse(strings1[1]));
    Console.WriteLine(s1);
    return s1;
}

void ContainsFunction(string? activationKey2, string[] array2)
{
    if (activationKey2.Contains(array2[1]))
    {
        Console.WriteLine($"{activationKey2} contains {array2[1]}");
    }
    else Console.WriteLine("Substring not found!");

    return;
}