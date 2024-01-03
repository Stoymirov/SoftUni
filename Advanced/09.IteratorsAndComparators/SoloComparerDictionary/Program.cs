








using System.Collections.Immutable;

SortedDictionary<Student, string> students = new SortedDictionary<Student, string>()
{
    { new Student("stefan", 2), "DolnoSelo" },
    { new Student("Gor", 4), "SrednoBezgradsko" },
    { new Student("W", 3), "GornoGradsto" }
};

foreach (var student in students)
{
    Console.WriteLine($"{student.Key.Name}:{student.Key.Grade} - {student.Value} ");
}
class Student:IComparable<Student>
{
    public Student(string name, int grade)
    {
        Name = name;
        Grade = grade;
    }
    public string Name { get; set; }
    public int Grade { get; set; }

    public int CompareTo(Student other)
    {
        int result = default;
        if (this.Grade > other.Grade)
            result = 1;
        if (this.Grade < other.Grade)
            result = -1;
        if (this.Grade == other.Grade)
            result = 0;
        return result;
    }
}

class ComparerPersonal : IComparer<Student>
{
    public int Compare(Student x, Student y)
    {
        int result = default;
        if (x.Grade > y.Grade)
            result = 1;
        if (x.Grade < y.Grade)
            result = -1;
        if (x.Grade == y.Grade)
            result = 0;
        return result;
    }
}