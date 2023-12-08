int n = int.Parse(Console.ReadLine());

Stack<string> textStack = new Stack<string>();
string text = string.Empty;
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    if (input[0] == "1")
    {
        textStack.Push(text);
        text += input[1];
    }
    else if (input[0] == "2")
    {
        textStack.Push(text);
        int count = int.Parse(input[1]);
        text = (text.Substring(0, text.Length - count));
    }
    else if (input[0] == "3")
    {
        int element = int.Parse(input[1]);
        Console.WriteLine(text[element-1]);
    }
    else if (input[0] == "4")
    {
        text = textStack.Pop();
       
    }

}
