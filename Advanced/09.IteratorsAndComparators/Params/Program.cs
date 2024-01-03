void PrintName(params string[] names)
{
    foreach (var name in names)
    {
        Console.WriteLine(name);
    }
}
PrintName("gosho","pesho");
