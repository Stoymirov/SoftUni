List<int> myList = ReadIntList();
string[] command = Console.ReadLine()
        .Split()
        .ToArray();
while (command[0] != "end")
{
    switch(command[0])
    {
        case "Contains":
           bool real = myList.Contains(int.Parse(command[1]));
            if (real)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
            break;
        case "PrintEven":
            Console.WriteLine(string.Join(" ", EvenNumbersArray(myList)));
            break;
        case "PrintOdd":
            Console.WriteLine(string.Join(" ", OddNumbersArray(myList)));
            break;
        case "GetSum":

            Console.WriteLine(Sum(myList));
            break;
        case "Filter":
            Console.WriteLine(string.Join(" ", Filter(myList, command[1], int.Parse(command[2]))));
            break;

    }
    command = Console.ReadLine()
        .Split()
        .ToArray();
}









static List<int> Filter(List<int> myList,string command, int number)
{
    List<int> result = new List<int>();
    foreach (int i in myList)  
    if (command == "<" && i < number)
        {
            result.Add(i);
        }
    else if (command == ">" && i > number)
        {
            result.Add(i);
        }
    else if (command =="<=" && i <= number)
        {
            result.Add(i);
        }
    else if (command == ">=" && i >= number)
        {
            result.Add(i);
        }
    return result;
}
static int Sum(List<int> list)
{
    int sum = 0;
    for (int i = 0; i < list.Count; i++)
    {
        sum += list[i];
    }
    return sum;
}
static List<int> EvenNumbersArray(List<int> myList)
{
    List<int> result = new List<int>(); 
    for (int i = 0; i<myList.Count; i++)
    {
        if (myList[i] % 2 == 0)
        {
            result.Add(myList[i]);
        }
    }
    return result;
}
static List<int> OddNumbersArray(List<int> myList)
{
    List<int> result = new List<int>();
    for (int i = 0; i < myList.Count; i++)
    {
        if (myList[i] % 2 != 0)
        {
            result.Add(myList[i]);
        }
    }
    return result;
}
static List<int> ReadIntList()
{
    return Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToList();
}