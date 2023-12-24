using System.Security.Cryptography.X509Certificates;

    Func<string, int> parser = x=>int.Parse(x);

int[] array = Console.ReadLine()
    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
    .Select(parser)
    .ToArray();
    Console.WriteLine(array.Length);
    Console.WriteLine(array.Sum());