List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();

string command;
while ((command = Console.ReadLine()) != "End")
{
    string[] commands = command.Split().ToArray();

    if (commands[0] == "Add")
    {
        int index = int.Parse(commands[1]);
        int value = int.Parse(commands[2]);
        if (index < 0 || index > commands.Length-1)// 01. трябва да бъде с минус 1.
        {
            Console.WriteLine("Invalid placement!");
        }
        else
        {
            targets.Insert(index, value);
        }
    }
    else if (commands[0] == "Strike")
    {
        int strikeIndex = int.Parse(commands[1]);
        int radius = int.Parse(commands[2]);

        if (strikeIndex - radius >= 0 && strikeIndex + radius <= targets[targets.Count - 1])// 02.<=
        {
            targets.RemoveRange(strikeIndex - radius, radius * 2 + 1);
        }
        else
        {
            Console.WriteLine($"Strike missed!");
        }
    }
    else if (commands[0] == "Shoot")
    {
        int index = int.Parse(commands[1]);
        int power = int.Parse(commands[2]);
        if (index < 0 || index > targets.Count-1)//03. count-1, не е && а || operator
        {
            continue;// 04. беше празен стейтмънта
        }
        else
        {
            targets[index] -= power;//тук съм сложил нова логика, виж си старата
            if (targets[index] <= 0)
            {
                targets.RemoveAt(index);
            }
        }


    }
}

Console.WriteLine(string.Join("|", targets));