using System.Security.AccessControl;

List<Student> students = new List<Student>()
{
    new Student("Dimi", 2),
    new Student("Pepi", 2),
    new Student("Gosho", 2)

};
students.Sort(new StudentsComparer());
class Student
{
    public Student(string name, int grade)
    {
        Grade = grade;
        Name = name;
    }

    public int Grade { get; set; }
    public string Name { get; set; }
}

class StudentsComparer:IComparer<Student>
{
    public int Compare(Student x, Student y)
    {
      int result = x.Grade.CompareTo(y.Grade);
      if (result == 0)
      {
          return x.Name.CompareTo(y.Name);
      }

      return result;
    }
}