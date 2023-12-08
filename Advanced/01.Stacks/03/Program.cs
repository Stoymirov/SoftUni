using System.Net.Sockets;

string[] array = Console.ReadLine().Split();
Stack<string> stack = new Stack<string>();
for (int i = array.Length - 1; i >= 0; i--)
{
    stack.Push(array[i]);
}

int result = 0;

if (stack.Count > 0)
{
    result = int.Parse(stack.Pop());
}

while (stack.Count > 0)
{
    string sign = stack.Pop();
    int number = int.Parse(stack.Pop());
    if (sign == "-")
    {
        result -=number;
    }
    else if (sign == "+")
    {
        result +=number;
    }
}

Console.WriteLine(result);