Dictionary<string, List<decimal>> studentGrades = new Dictionary<string, List<decimal>>();

int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    string name = input[0];
    decimal grade = decimal.Parse(input[1]);

    if (!studentGrades.ContainsKey(name))
    {
        studentGrades.Add(name, new List<decimal>());
    }
    studentGrades[name].Add(grade);
}

foreach (var studentGrade in studentGrades)
{
    Console.WriteLine($"{studentGrade.Key} -> {string.Join(" ", studentGrade.Value.Select(x=>($"{x:f2}")))} (avg: {studentGrade.Value.Average():f2})");
    //Console.Write($"{studentGrade.Key} -> ");

    //foreach (var gradees in studentGrade.Value)
    //{
    //    Console.Write($"{gradees:f2} ");
    //}

    //Console.WriteLine($"(avg: {studentGrade.Value.Average():f2})");
}