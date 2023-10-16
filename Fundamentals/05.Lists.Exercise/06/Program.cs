string[] stringArray = Console.ReadLine()
    .Split('|', StringSplitOptions.RemoveEmptyEntries).ToArray();

var myList = MyList(stringArray);



Console.WriteLine(string.Join(" ", myList));

static List<string> MyList(string[] strings)
{
    List<string> list = new List<string>();
    for (int i = strings.Length - 1; i >= 0; i--)
    {
        string sequence = strings[i];
        string[] myArray = sequence.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
        list.AddRange(myArray);
    }

    return list;
}