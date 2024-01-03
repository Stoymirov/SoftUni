
Student pesho = new Student() { Grade = 2 };
Student gosho = new Student() { Grade = 5 };

Console.WriteLine(pesho.CompareTo(gosho));
List<Student> students = new List<Student>();
students.Add(gosho);
students.Add(pesho);

class Student:IComparable<Student>
{
    public int Grade { get; set; }

    public int CompareTo(Student other)
    {
        if(this.Grade < other.Grade) return -1;
        if(this.Grade == other.Grade) return 0;
        if(this.Grade > other.Grade) return 1;

        return default;
    }
}