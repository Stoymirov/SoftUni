
using EqualityLogic;

HashSet<Person> hs = new();
SortedSet<Person> shs = new();
int count = int.Parse(Console.ReadLine());
for (int i = 0; i < count; i++)
{
    string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    Person person = new Person();
    person.Name = tokens[0];
    person.Age= int.Parse(tokens[1]);

    hs.Add(person);
    shs.Add(person);
    
}

Console.WriteLine(hs.Count);
Console.WriteLine(shs.Count);