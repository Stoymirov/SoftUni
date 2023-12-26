Student student = new Student();
student.FirstName = "pesho";
Console.WriteLine(student.FirstName);

class Student
{
    private string firstName;

    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        set
        {
            firstName = value;
        }
    }
}