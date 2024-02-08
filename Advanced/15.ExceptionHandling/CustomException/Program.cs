using CustomException;

Student student = new Student();

try
{
    student.Age = 122;
}
catch (CustomExc ex)
{
    Console.WriteLine(student.Age);
    Console.WriteLine(ex.From);
    Console.WriteLine(ex.To);
    Console.WriteLine(ex.Message);
}
class Student
{
    private int age = 2;
    public int Age
    {
        get => age;

        set
        {
            if (value < 0 || value > 10)
            {
                throw new CustomExc(11,22);
            }
            value = age;
        }
    }
}
