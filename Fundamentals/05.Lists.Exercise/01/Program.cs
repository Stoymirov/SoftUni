string input = Console.ReadLine();
List<int> myList = ReadList(input);

int maxPapacity = int.Parse(Console.ReadLine());

string[] command = new string[2];
command = Console.ReadLine()
    .Split()
    .ToArray();
while (command[0] != "end")
{
    if (command[0] =="Add")
    {
        myList.Add(int.Parse(command[1]));
    }
    else
    {
        for (int i = 0; i < myList.Count; i++)
        {
            if (int.Parse(command[0]) +myList[i] <=maxPapacity)
            {
                myList[i] += int.Parse(command[0]);
                break;
            }
        }
    }
    command = Console.ReadLine()
    .Split()
    .ToArray();
}
Console.WriteLine(string.Join(" ", myList));















static List<int> ReadList(string intput)
    {
        List<int> list = intput
            .Split()
            .Select(int.Parse).ToList();
        return list;
    }