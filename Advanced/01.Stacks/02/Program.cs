using System.Drawing;
Stack<int> stackOfInts = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

string command = "".ToLower();

while ((command = Console.ReadLine().ToLower()) != "end")
{
    string[] array = command.Split().ToArray();
    switch (array[0])
    {
        case "add":
            for (int i = 1; i < array.Length; i++)
            {
                stackOfInts.Push(int.Parse(array[i]));
            }

            break;
        case "remove":
            if (stackOfInts.Count >= int.Parse(array[1]))
            {
                for (int i = 0; i < int.Parse(array[1]); i++)
                {

                    stackOfInts.Pop();

                }
            }

            break;
    }
}

Console.WriteLine($"Sum: {stackOfInts.Sum(x => x)}");
