List<int> input = Console.ReadLine().Split().Select(int.Parse).ToArray();
string command= "";


Action<List<int>> printer = p => Console.WriteLine(string.Join(" ",p));
Func<List<int>,string, List<int>> func = (array,st) =>
{
    switch (st)
    {
        case "add":
            for (int i = 0; i < array.Length; i++)
            {
                array[i]++;
            }

            break;
        case "subtract":
            for (int i = 0; i < array.Length; i++)
            {
                array[i]--;
            }

            break;
        case "multiply":
            for (int i = 0; i < array.Length; i++)
            {
                array[i]*=2;
            }

            break;
       
    }

    return array;
};
while ((command = Console.ReadLine()) != "end")
{
    if (command == "print")
    {
        printer(input);
    }
    else
    {
        func(input,command);
    }
}