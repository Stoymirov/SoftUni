int n = int.Parse(Console.ReadLine());
List<Student> list = new List<Student>();
for (int i = 0; i < n; i++)
{
    string[] array = Console.ReadLine().Split();
    Student student = new Student();

    student.FirstName = array[0];
    student.LastName = array[1];
    student.Grade = float.Parse(array[2]);
    list.Add(student);

    
}

list = list.OrderByDescending(x => x.Grade).ToList();
Console.WriteLine(string.Join("\n", list));

/*4
Lakia Eason 3.90
Prince Messing 5.49
Akiko Segers 4.85
Rocco Erben 6.00*/









class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public float Grade { get; set; }
    public override string ToString()
    {
        return ($"{FirstName} {LastName}: {Grade:f2}.");
    }
}
