using System.Text;

int biggest = BiggestElement(1, 2, 3);
StringBuilder sb = new StringBuilder();
//StringBuilder biggests = BiggestElement(sb, sb, sb);
List<Student> students = new List<Student>() { new Student(3), new Student(4.5), new Student(2) };
Student student = BiggestElement<Student>(students[0], students[1], students[2]);

Console.WriteLine(student.AverageGrade);
Dictionary<int, Student> studentsDic = new Dictionary<int, Student>()
{
    {1,new Student(2)},
    {2,new Student(4)},
    {3,new Student(5.5)},
    {4,new Student(2)},

};

Student BestStudentFromDic = new Student();
foreach (var student1 in studentsDic)
{
    if (student1.Value.CompareTo(BestStudentFromDic) >0)
    {
        BestStudentFromDic = student1.Value;
    }
}




T BiggestElement<T>(T first, T second, T third) where T : IComparable<T>// the T must have a implement IComaparable and have CompareTo method to work
{
    if (first.CompareTo(second) > 0 && (first.CompareTo(third) > 0))
    {
        return first;
    }
    if (second.CompareTo(first) > 0 && (second.CompareTo(third) > 0))
    {
        return second;
    }
    if (third.CompareTo(second) > 0 && (third.CompareTo(first) > 0))
    {
        return third;
    }
    return default(T);
}

class Student : IComparable<Student>
{
    public double AverageGrade {get; set; }

    public Student(double grade)
    {
        AverageGrade = grade;
    }
    public Student()
    {
       
    }

    public int CompareTo(Student other)
    {
        if (AverageGrade < other.AverageGrade) 
            return -1;
        if (AverageGrade == other.AverageGrade)
            return 0;
        if (AverageGrade > other.AverageGrade)
            return 1;
        return default;
    }
}
