using System.Drawing;
Stack<int> stackOfInts = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

string command = "".ToLower();

while ((command = Console.ReadLine().ToLower()) != "end")
{
    string[] split = command.Split();

    if (command.Contains("add"))
    {
        int first = int.Parse(split[1]);
        int two = int.Parse(split[2]);
        stackOfInts.Push(first);
        stackOfInts.Push(two);
    }
    else
    {
        int n = int.Parse(split[1]);
        if (n <= stackOfInts.Count)
        {
            for (int i = 0; i < n; i++)
            {
                stackOfInts.Pop();
            }
        }
    }
}

Console.WriteLine($"Sum: {stackOfInts.Sum(x => x)}");