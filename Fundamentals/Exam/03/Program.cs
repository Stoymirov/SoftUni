using System.Collections.Specialized;

int capacity = int.Parse(Console.ReadLine());
List<Person> people = new List<Person>();
string command = "";
while ((command = Console.ReadLine()) != "Statistics")
{
    string[] array = command.Split("=").ToArray();
    switch (array[0])
    {
        case "Add":
            if (people.All(x => x.Name != array[1]))
            {
                Person person = new Person();
                person.Name = array[1];
                person.Sent = int.Parse(array[2]);
                person.Received = int.Parse(array[3]);
                people.Add(person);
            }
            break;
        case "Message":
            if (people.Exists(x => x.Name == array[1]) && people.Exists(c => c.Name == array[2]))
            {
                var person = people.Find(x => x.Name == array[1]);
                person.Sent++;
                var person2 = people.Find(x => x.Name == array[2]);
                person2.Received++;
                if (person.Sent + person.Received >= capacity)
                {
                    people.Remove(person);
                    Console.WriteLine($"{person.Name} reached the capacity!");
                }
                if (person2.Sent + person2.Received >= capacity)
                {
                    people.Remove(person2);
                    Console.WriteLine($"{person2.Name} reached the capacity!");
                }
            }


            break;
        case "Empty":
            {
                if (array[1] != "All")
                {
                    if (people.Exists(x => x.Name == array[1]))
                    {
                        people.Remove(people.Find(x => x.Name == array[1]));
                    }
                }
                else
                {
                    people.Clear();
                }
            }
            break;
    }
}

Console.WriteLine($"Users count: {people.Count}");
foreach (var person in people)
{
    Console.WriteLine($"{person.Name} - {person.Received + person.Sent}");
}





class Person
{
    public string Name { get; set; }
    public int Sent { get; set; }
    public int Received { get; set; }
}