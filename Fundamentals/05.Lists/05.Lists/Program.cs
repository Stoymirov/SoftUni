    List<double> decimals = Console.ReadLine()
        .Split()
        .Select(double.Parse)
        .ToList();

    for (int i = 0; i < decimals.Count - 1; i++)
    {
        if (decimals[i] == decimals[i + 1])
        {
            decimals[i] = decimals[i] + decimals[i + 1];
            decimals.RemoveAt(i + 1);
            i = -1;
        }
    }
    Console.WriteLine(string.Join(" ", decimals));
}