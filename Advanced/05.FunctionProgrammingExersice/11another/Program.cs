using System.Reflection;

int n = int.Parse(Console.ReadLine());
List<string> people = Console.ReadLine().Split().ToList();

Func<string, int, bool> checkEqualOrNot = (name, sum) => name.Sum(ch => ch) >= sum;

Func<List<string>, int, Func<string, int, bool>, string> result =
    (names, sum, func) =>
    {
        return names.FirstOrDefault(p => func(p, sum));
    };
Console.WriteLine(result(people,n,checkEqualOrNot));