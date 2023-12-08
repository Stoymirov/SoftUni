Stack<int> indexOfOpening = new Stack<int>();

string input = Console.ReadLine();

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '(')
    {
        indexOfOpening.Push(i); 
    }
    else if (input[i] == ')')
    {
        int index = indexOfOpening.Pop();
        string substring = input.Substring(index, i-index+1);
        Console.WriteLine(substring);
    }
    
}