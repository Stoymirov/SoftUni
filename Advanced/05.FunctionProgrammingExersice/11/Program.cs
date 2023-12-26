int n = int.Parse(Console.ReadLine());
List<string> people = Console.ReadLine().Split().ToList();
Func<List<string>, Predicate<string>, string> findPerson = (list, pred) =>
{
    foreach (string person in people)
    {
        if (pred(person))
        {
            return person;
        }
    }

    return default;
};
Predicate<string> pred = p =>
{
    int sum = 0;
    foreach (var VARIABLE in p)
    {
        sum += VARIABLE;
    }

    return sum >= n;
};
   string person = findPerson(people,pred);
Console.WriteLine(person);


