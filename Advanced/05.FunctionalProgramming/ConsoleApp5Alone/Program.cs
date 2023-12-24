/*
1. take a number as input
2. accept name and age
3. accept younger or older
4. accept threshold
5. formatting 
print all people that according to the prerequisites 
 create a ReadInputMethod
 create a Print outputmethod which takes in the people list, then the function for selection and then function for formatting
 */

using System.Reflection.Metadata.Ecma335;


Person[] people = ReadInput();
string predicate = Console.ReadLine();
int threshold = int.Parse(Console.ReadLine());
string format = Console.ReadLine();

Func<Person, bool> checker = Checker(predicate, threshold);

Action<Person> printer = Printer(format);

OutPutMethod(people, checker,printer);

void OutPutMethod(Person[] people, Func<Person,bool> funca,Action<Person> nz)
{
    people = people.Where(p => funca(p)).ToArray();
    foreach (var person in people)
    {
        nz(person);
    }
}



Func<Person, bool> Checker(string predicate, int threshold)
{
    if (predicate == "younger")
    {
        return p => p.Age < threshold;
    }
    else
    {
        return p=>p.Age >= threshold;
    }
}


Action<Person> Printer(string format)
{
    if (format == "name age")
    {
        return p => Console.WriteLine($"{p.Name} - {p.Age}");
    }
    else if (format == "name")
    {
        return p => Console.WriteLine(p.Name);
    }
    else
    {
        return p => Console.WriteLine(p.Age);

    }
}

Person[] ReadInput()
{
    int n = int.Parse(Console.ReadLine());
    List<Person> people = new List<Person>();
    for (int i = 0; i < n; i++)
    {
        string[] input = Console.ReadLine().Split(", ");
        string name = input[0];
        int age = int.Parse(input[1]);
        Person person = new Person();
        person.Age= age;
        person.Name = name;
        people.Add(person);
    }
    return people.ToArray();
}






class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}