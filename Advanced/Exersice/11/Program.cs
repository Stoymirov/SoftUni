using System.IO.Enumeration;

List<string> names = Console.ReadLine().Split().ToList();
string command = default;
while ((command = Console.ReadLine()) != "Party!")
{
    string[] tokens = command.Split();
    var pred = Predicate(tokens);
    if (tokens[0] == "Remove")
    {
        names.RemoveAll(x => pred(x));
    }
    else
    {
        List<string> peopleToDouble = names.FindAll(x => pred(x));
        foreach (var person in peopleToDouble)
        {
            int index = names.IndexOf(person);
            names.Insert(index,person);
        }
    }
}

Console.WriteLine(string.Join(", ",names));

Predicate<string> Predicate(string[] array)
{
    if (array[1] == "StartsWith")
    {
        return x => x.StartsWith(array[2]);
    }
    else if (array[1] == "EndsWith")
    {
        return x => x.EndsWith(array[2]);
    }
    else
    {
        return x => x.Length == int.Parse(array[2]);
    }

}