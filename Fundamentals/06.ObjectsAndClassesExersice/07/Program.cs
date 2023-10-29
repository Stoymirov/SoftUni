using System.Runtime.CompilerServices;

string command = "";
List<Person> people = new List<Person>();
while ((command = Console.ReadLine()) != "End")
{

    string[] array = command.Split();
    string name = array[0];
    long ID =long.Parse(array[1]);
    int age = int.Parse(array[2]);

    Person person = new Person(name, ID, age);
    bool sameIDFOund = people.Any(x => x.ID == ID);
    if (!sameIDFOund)
    {
        people.Add(person);
    }
    else
    {
        person.Editor(name,age);
    }
}

people = people.OrderBy(x => x.Age).ToList();
foreach (Person person in people)
{
    Console.WriteLine(person);
}

class Person
{
   public Person(string name, long iD, int age)
    {
        Name = name;
        ID = iD;
        Age = age;
    }

    public string Name  { get; set; }
    public long ID { get; set; }
    public int Age { get; set; }

    
    public void Editor(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"{Name} with ID: {ID} is {Age} years old.";
    }
}