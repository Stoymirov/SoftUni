using ComparingObjects;


int equalPeople = 0;
List<Person> people = new List<Person>();
string input = "";
while ((input = Console.ReadLine()) != "END")
{
    string[] tokens = input.Split();
    Person person = new Person();
    person.Name = tokens[0];
    person.Age = int.Parse(tokens[1]);
    person.Town = tokens[2];
    people.Add(person);
}

int index = int.Parse(Console.ReadLine());
foreach (var person in people)
{
    if (people[index-1].CompareTo(person) == 0)
    {
        
        equalPeople += 1;

        
    }
   
}

if (equalPeople == 1)
{
    Console.WriteLine("No matches");
}
else
{
    Console.WriteLine($"{equalPeople} {people.Count-equalPeople} {people.Count}");
}