IEnumerator<string> enumerator = IterateNames();
while (enumerator.MoveNext())
{
    Console.WriteLine(enumerator.Current);
}

IEnumerator<string> IterateNames()
{
    Console.WriteLine("first");
    yield return "Pesho";
    Console.WriteLine("second");
    yield return "Gosho";
    Console.WriteLine("Third");
    yield return "Dimitrichko";
}