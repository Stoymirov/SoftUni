string inputParenthesis = Console.ReadLine();

Stack<char> stack = new Stack<char>();

foreach (var inputParenthesi in inputParenthesis)
{
    var currentValue = stack.TryPeek(out var res);
    if (inputParenthesi == '('
        || inputParenthesi == '{'
        || inputParenthesi == '[')
    {
        stack.Push(inputParenthesi);
    }

    if (stack.Count == 0)
    {
        stack.Push(inputParenthesi);
        break;
    }
    if (inputParenthesi == ')' && res == '(')
    {
        stack.Pop();
    }
    else if (inputParenthesi == ']' && res == '[')
    {
        stack.Pop();
    }
    else if (inputParenthesi == '}' && res == '{')
    {
        stack.Pop();
    }
}

if (stack.Count == 0)
{
    Console.WriteLine("YES");
}
else Console.WriteLine("NO");