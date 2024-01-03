using System.Collections.Immutable;
using System.Threading.Channels;

int n = int.Parse(Console.ReadLine());
List<Person> people = new List<Person>();
for (int i = 0; i < n; i++)
{
    string[] array = Console.ReadLine().Split(", ");
    string name = array[0];
    int age = int.Parse(array[1]);
    Person person = new Person(name, age);

    people.Add(person);
}
string condition = Console.ReadLine();
int threshold = int.Parse(Console.ReadLine());
string format = Console.ReadLine();

Func<Person, bool> filter = CreateFilter(condition, threshold);

Func<Person, bool> CreateFilter(string s, int i)
{

    if (s == "younger")
    {
        return x => x.Age < i;
    }
    else
    {
        return x => x.Age >= i;
    }
}

Action<Person> printer = CreatePrinter(format);

Action<Person> CreatePrinter(string format)
{
    if (format == "name age")
    {
        return x => Console.WriteLine($"{x.Name} - {x.Age}");
    }
    else if (format == "name")
    {
        return x => Console.WriteLine($"{x.Name}");

    }
    else
    {
        return x => Console.WriteLine($"{x.Age}");

    }

};
PrintFilteredPeople(people,printer,filter)
;static void PrintFilteredPeople(List<Person> people, Action<Person> printer, Func<Person, bool> filter)
{
    List<Person> filteredList = new List<Person>();
    foreach (var person in people)
    {
        if (filter(person))
        {
            filteredList.Add(person);
        }
    }

    foreach (var person in filteredList)
    {
        printer(person);
    }
}
class Person
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public string Name { get; set; }
    public int Age { get; set; }
}