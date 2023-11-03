string input = Console.ReadLine();

Dictionary<char, int> myDictionary = new Dictionary<char, int>();

for (int i = 0; i < input.Length; i++)
{


    char myChar = input[i];
    if (myChar == ' ')
    {
        continue;
    }
    if (!myDictionary.ContainsKey(myChar))
    {
        myDictionary.Add(myChar, 0);
    }

    myDictionary[myChar]++;

}

foreach (var variable in myDictionary)
{
    Console.WriteLine($"{variable.Key} -> {variable.Value}");
}