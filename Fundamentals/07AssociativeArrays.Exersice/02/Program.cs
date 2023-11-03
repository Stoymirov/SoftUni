Dictionary<string, int> myDictionary =  new Dictionary<string, int>();

string command = "";
while ((command = Console.ReadLine()) != "stop")
{
    int secondCommand = int.Parse(Console.ReadLine());
    if (!myDictionary.ContainsKey(command))
    {
        myDictionary.Add(command, 0);
    }

    myDictionary[command] += secondCommand;
}

foreach (var VARIABLE in myDictionary)
{
    Console.WriteLine($"{VARIABLE.Key} -> {VARIABLE.Value}");
}