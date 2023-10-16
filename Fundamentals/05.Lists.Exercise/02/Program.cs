List<int> list = Console.ReadLine()
            .Split()
            .Select(int.Parse).ToList();
string command =  Console.ReadLine();
while (command != "end")
{
    string[] commandArray = command.Split().ToArray();
    if (commandArray[0] == "Delete")
    {

        list.RemoveAll(x=> x==int.Parse((commandArray[1])));
        
    }
    else
    {
        list.Insert(int.Parse(commandArray[2]), int.Parse(commandArray[1]));
    }
    command = Console.ReadLine();
}
Console.WriteLine(string.Join(" ", list));

