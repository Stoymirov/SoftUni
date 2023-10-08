double grade = double.Parse(Console.ReadLine());

Grade(grade);
//Console.Write($"Retake Exam Grade is: ");
//double newGrade = double.Parse(Console.ReadLine()); // additional exercicing
//Grade(newGrade);
static void Grade(double grade)
{
    switch (grade)
    {
        case >= 2 and <= 2.99:
            Console.WriteLine("Fail");
            break;
        case >= 3 and <= 3.49:
            Console.WriteLine("Poor");
            break;
        case >= 3.5 and <= 4.49:
            Console.WriteLine("Good");
            break;
        case >= 4.5 and <= 5.49:
            Console.WriteLine("Very good");
            break;
        case >= 5.5 and <= 6:
            Console.WriteLine("Excellent");
            break;

    }
}
