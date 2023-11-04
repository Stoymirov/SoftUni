using System.Runtime.CompilerServices;

int n = int.Parse(Console.ReadLine());

Dictionary<string, Student> database = new Dictionary<string, Student>();
for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());

    if (!database.ContainsKey(name))
    {
        Student student = new Student(name);
        database.Add(student.Name, student);
    }
    database[name].Grades.Add(grade);
}

var filtered = database.Where(x => x.Value.Grade());
foreach (var VARIABLE in filtered)
{
    Console.WriteLine(VARIABLE.Value);
}





class Student
{
    public Student(string name)
    {
        Name = name;
        Grades = new List<double>();
    }
    public string Name { get; set; }

    public List<double> Grades;
    public bool Grade()
    {
        if (Grades.Sum() / Grades.Count >= 4.5)
        {
            return true;
        }

        return false;
    }

    public override string ToString()
    {
        return $"{Name} -> {Grades.Sum() / Grades.Count:f2}";
    }
}