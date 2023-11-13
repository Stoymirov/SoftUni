

int[] array = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();



string input = String.Empty;
List<string> listOfCommands = new List<string>();
while ((input = Console.ReadLine()) != "find")
{
    string resultString = String.Empty;
    int arrayIndex = -1;
    foreach (int character in input)
    {
        arrayIndex++;
        int indexToAdd = array[arrayIndex];
        int currentChar = (int)character-indexToAdd;
        resultString += (char)(currentChar);
        if (arrayIndex == array.Length - 1)
        {
            arrayIndex = -1;

        }
       
    }
    listOfCommands.Add(resultString);
}

foreach (var VARIABLE in listOfCommands)
{
    int indexOfFirstFinding = VARIABLE.IndexOf('&');
    int indexOfSecondFinding = VARIABLE.LastIndexOf('&');
    string material = VARIABLE.Substring(indexOfFirstFinding+1, indexOfSecondFinding - indexOfFirstFinding-1);
    int indexOfFirst1Finding = VARIABLE.IndexOf('<');
    int indexOfSecond2Finding = VARIABLE.LastIndexOf('>');
    string coordinates = VARIABLE.Substring(indexOfFirst1Finding + 1, indexOfSecond2Finding - indexOfFirst1Finding - 1);
    Console.WriteLine($"Found {material} at {coordinates}");
}