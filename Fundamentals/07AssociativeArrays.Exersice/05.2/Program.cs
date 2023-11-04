string command = string.Empty;

Dictionary<string, Courses> courses = new Dictionary<string, Courses>();
while ((command = Console.ReadLine()) != "end")
{
    string[] array = command.Split(" : ");
    string courseName = array[0];
    string personName = array[1];
    if (!courses.ContainsKey(courseName))
    {
        Courses course = new Courses(courseName);
        courses.Add(course.Name, course);
    }
    courses[courseName].StudentsNames.Add(personName);


}

foreach (KeyValuePair<string,Courses> kvp in courses)
{
    Console.WriteLine(kvp.Value);
}







class Courses
{
    public Courses(string name)
    {
        Name = name;
        StudentsNames = new List<string>();
    }

    public string Name;
    public List<string> StudentsNames;

    public override string ToString()
    {
        string result = $"{Name}: {StudentsNames.Count}\n";

        foreach (var VARIABLE in StudentsNames)
        {
            result += $"-- {VARIABLE}\n";
        }

        return result.Trim();
    }
}





