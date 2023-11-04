string command = string.Empty;

List<Courses> courses = new List<Courses>();
while ((command = Console.ReadLine()) != "end")
{
    string[] array = command.Split(" : ");
    string courseName = array[0];
    string personName = array[1];
    if(!courses.Exists(x=>x.CourseName == courseName))
    {
        Courses course = new Courses(courseName,personName);
        courses.Add(course);
    }
    else
    {
        int index = courses.FindIndex(x => x.CourseName == courseName);
        courses[index].Students.Add(personName);
    }
}
foreach (Courses course in courses)
{
    Console.WriteLine($"{course.CourseName}: {course.Students.Count}\n-- {string.Join("\n-- ",course.Students)}");
}







class Courses
{
    public Courses(string courseName, string student)
    {
        CourseName = courseName;
        
       Students = new List<string>();
        Students.Add(student);
    }

    public string CourseName { get; set; }
   public List<string> Students { get; set; }
}