
List<Person> people = new List<Person>();
people.Add(new Person() { Name = "ivan", Age = 2 });
people.Add(new Person() { Name = "dd", Age = 1 });
people.Add(new Person() { Name = "aa", Age = -13 });
people.Add(new Person() { Name = "ss", Age = 33 });


//foreach (var person in people.OrderBy(x=>x))
//{
//    Console.WriteLine(person);
//}




Person persona = new Person() { Name = "ivan", Age = 2 };
Person persona2 = new Person() { Name = "dd", Age = 1 };

IComparator comparator = new IComparator();
Console.WriteLine(comparator.Compare(persona,persona2));
class Person
{
    public string   Name { get; set; }
    public int Age { get; set; }


    public override string ToString()
    {
        return $"{Name} - {Age}";
    }

    //public int CompareTo(Person other)
    //{
    //    if (Age < other.Age)
    //    {
    //        return 1;
    //    }
    //    else
    //    {
    //        return -1;
    //    }
    //}
}

class IComparator : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        if (x.Age < y.Age)
        {
            return -1;
        }
        else return 1;
    }
}