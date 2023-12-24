

using System.Runtime.InteropServices.ComTypes;

List<Person> people = ReadPeople();
string condition = Console.ReadLine();
int ageThreshold = int.Parse(Console.ReadLine());
string format = Console.ReadLine();

 
Func<Person,int, bool> filter = CreateFilter(condition);

people = people.Where(x=>filter(x,ageThreshold)).ToList();

Action<Person> printer = CreatePrinter(format);

foreach (var person in people)
{
    printer(person);
}
Func<Person,int, bool> CreateFilter(string condition)
{
    if (condition == "younger")
    {
        return (p, value) => p.Age < value;
    }
    else
    {
        return (p,value)=>p.Age >= value;
    }
}


static List<Person> ReadPeople()
{
    int n = int.Parse(Console.ReadLine());
    var people = new List<Person>();
    for (int i = 0; i < n; i++)
    {
        string[] array = Console.ReadLine().Split(", ");
        Person person = new Person();
        person.Name = array[0];
        person.Age = int.Parse(array[1]);
        people.Add(person);
    }
    return people;
}


Action<Person> CreatePrinter(string format)
{
    string[] array = format.Split(' ');
    if (array.Length == 2)
    {
        return p => Console.WriteLine($"{p.Name} - {p.Age}");
    }
    else if (array[0] == "name")
    {
        return p => Console.WriteLine(p.Name);
    }
    else
    {
        return p => Console.WriteLine(p.Age);

    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}