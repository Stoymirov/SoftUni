List<string> names = Console.ReadLine().Split().ToList();

Dictionary<string, Predicate<string>> preds = new Dictionary<string, Predicate<string>>();

string command = default;
while ((command = Console.ReadLine()) != "Print")
{
    string[] array = command.Split(";");
    if (array[0].Contains("Add"))
    {
        var pred = Predicate(array);
        preds.Add(array[1] + array[2], pred);
    }
    else
    {
        preds.Remove(array[1] + array[2]);
    }
}

List<string> newNames = new List<string>();
foreach (var name in names)
{
    bool isGood = true;
    foreach (var predicate in preds.Values)
    {
        if (predicate(name))
            isGood = false;
    }
    if (isGood)
        newNames.Add(name);
}

Console.WriteLine(string.Join(" ",newNames));

Predicate<string> Predicate(string[] array)
{

    if (array[1].Contains("Starts"))
    {
        return x => x[0].ToString() == array[2];
    }
    else if (array[1].Contains("Ends"))
    {
        return x => x[^1].ToString() == array[2];
    }
    else if (array[1].Contains("Length"))
    {
        return x => x.Length == int.Parse(array[2]);
    }
    else
    {
        return x => x.Contains(array[2]);
    }

}