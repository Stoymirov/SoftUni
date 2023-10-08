static string ConcatenationOfStrings(string input, int count)
{
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result += input; 
    }
    return result;
}

string input = Console.ReadLine();
int count = int.Parse(Console.ReadLine());
Console.WriteLine(ConcatenationOfStrings(input,count));