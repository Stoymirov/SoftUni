string[] array = Console.ReadLine().Split(", ").ToArray();

Queue<string> songs = new Queue<string>(array);
;
while (true)
{
    string[] commandInput = Console.ReadLine().Split();
    if (commandInput[0] == "Play")
    {
        if (songs.Count > 0)
        {
            songs.Dequeue();
        }

        if (songs.Count == 0)
        {
            Console.WriteLine("No more songs!");
            break;
        }
    }
    else if (commandInput[0] == "Add")
    {
        //Add Watch me
        //["Add", "Watch", "Me"]
        //["Watch", "Me"]
        //string.Join -> "Watch Me"
        string songName = string.Join(" ", commandInput.Skip(1));
        if (songs.Contains(songName))
        {
            Console.WriteLine($"{songName} is already contained!");
        }
        else
        {
            songs.Enqueue(songName);
        }

    }
    else if (commandInput[0] == "Show")

    {
        Console.WriteLine(string.Join(", ", songs));
    }
}