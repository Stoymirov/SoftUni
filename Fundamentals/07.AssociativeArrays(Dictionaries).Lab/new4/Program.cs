Console.WriteLine(string.Join(Environment.NewLine, Console.ReadLine()
    .Split()
    .Where(x=>x.Length%2==0)
    .ToList()));