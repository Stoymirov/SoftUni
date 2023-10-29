int n = int.Parse(Console.ReadLine());
Family family = new Family();
for (int i = 0; i < n; i++)
{
    string[] array = Console.ReadLine().Split();
    Person person = new Person();

    family.AddMember(array[0], int.Parse(array[1]));
}
Person f = family.GetOldestMember();
Console.WriteLine(f);






class Family
{
    public Family()
    {
        People = new List<Person>();
    }
    public List<Person> People { get; set; }

    public void AddMember(string name, int age)
    {
        Person person = new Person();
        person.Name = name;
        person.Age = age;
        People.Add(person);
    }

    public Person GetOldestMember()
    {
        Person oldestPErson = People.OrderByDescending(p => p.Age).First();
        return oldestPErson;
    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public override string ToString()
    {
        return $"{Name} {Age}";
    }
}