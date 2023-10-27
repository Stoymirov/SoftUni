//•	first name
//•	last name
//•	age
//•	home town 
List<Student> list = new List<Student>();
string command = "";
while ((command = Console.ReadLine()) != "end")
{
    string[] array = command.Split();
    string firstName = array[0];
    string lastName = array[1]; ;
    int age = int.Parse(array[2]);
    string city = array[3];

    bool studentExists = false;


    studentExists = list.Any(n => n.FirstName == firstName && n.LastName == lastName);

    if (!studentExists)
    {
        Student student = new Student(firstName, lastName, age, city);
        list.Add(student);
    }
    else
    {
        int index =list.FindIndex(x => x.FirstName == firstName && x.LastName == lastName);
        list[index].Age = age; list[index].HomeTown = city;
    }
}
string cityControl = Console.ReadLine();
foreach (Student element in list)
{
    if (element.HomeTown == cityControl)
    {
        Console.WriteLine($"{element.FirstName} {element.LastName} is {element.Age} years old.");
    }
}

class Student
{
    public Student(string firstName, string lastName, int age, string homeTown)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        HomeTown = homeTown;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }
}