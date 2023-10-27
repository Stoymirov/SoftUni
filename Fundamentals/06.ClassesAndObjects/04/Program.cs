string command = "";
List<Students> myStudentsList = new List<Students>();
while ((command = Console.ReadLine()) != "end")
{

    string[] input = command.Split();
    Students student = new Students(input[0], input[1], input[2], input[3]);
    
    int index = StudentIsExisting(myStudentsList, input[0], input[1]);
    if (index != -1)
    {
        myStudentsList[index].age = input[2];
        myStudentsList[index].homeTown = input[3];
        continue;
    }
    myStudentsList.Add(student);


}
string city = Console.ReadLine();



List<Students> filtereStudentsList = myStudentsList.Where(s => s.homeTown == city).ToList();
foreach (Students s in filtereStudentsList)
{
    Console.WriteLine($"{s.FirstName} {s.LastName} is {s.age} years old.");
}
//foreach (Students student in myStudentsList)
//{
//    if (student.homeTown == city)
//    {
//        Console.WriteLine($"{student.FirstName} {student.LastName} is {student.age} years old.");
//    }
//}
static Students GetStudent(List<Students> students, string firstName, string lastName)
{
    Students existingStudent = null;
    foreach (Students student in students)
    {
        if (student.FirstName == firstName && student.LastName == lastName)
        {
            existingStudent = student;
        }
    }

    return existingStudent;
}
static int StudentIsExisting(List<Students> students, string firstName, string lastName)
{
    for (int i = 0; i < students.Count; i++)
    {

        if (students[i].FirstName == firstName && students[i].LastName == lastName) return i;
    }

    return -1;
}

class Students
{
    public Students()
    {
        
    }
    public Students(string firstName, string lastName, string age, string homeTown)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.age = age;
        this.homeTown = homeTown;
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string age { get; set; }
    public string homeTown { get; set; }
}
