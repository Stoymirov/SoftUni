string[] array = Console.ReadLine().Split(", ");

foreach (var username in array)
{

    if (username.Length < 3 || username.Length > 16)
    {
        continue;
    }
    bool isValid = username.All(x => char.IsLetterOrDigit(x) || x == '_' || x == '-');
    if (isValid)
    {
        Console.WriteLine(username);
    }

}