List<string> people = Console.ReadLine().Split().ToList();
string command = "";

Dictionary<string, Predicate<string>> predicates = new Dictionary<string, Predicate<string>>();
while ((command = Console.ReadLine()) != "Print")
{
    string[] tokens = command.Split(";",StringSplitOptions.RemoveEmptyEntries).ToArray();

    string commander = tokens[0];
    string filterType = tokens[1];
    string value = tokens[2];

    if (commander == "Add filter")
    {
        predicates.Add(filterType + value, FindThePredicate(filterType, value));
    }
    else
    {
        predicates.Remove(filterType + value);
    }
}

foreach (var predicate in predicates)
{
    people.RemoveAll(predicate.Value);
}
Console.WriteLine(string.Join(" ",people));
Predicate<string> FindThePredicate(string type, string value)
{
    switch (type)
    {
        case "Starts with":

            return p => p.StartsWith(value);
        case "Ends with":

            return p => p.EndsWith(value);
        case "Length":
            return p => p.Length == int.Parse(value);

        case "Contains":
            return p => p.Contains(value);
    }
    return default;
}