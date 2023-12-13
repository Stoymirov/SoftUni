Dictionary<string, int> studentsAges = new Dictionary<string, int>();

studentsAges["Pesho"] = 21;
studentsAges["Azam"] = 51;
studentsAges["Goshko"] = 31;

studentsAges = studentsAges.OrderBy(s => s.Key).ToDictionary(s => s.Key, s => s.Value);
foreach (var studentsAge in studentsAges)
{
    Console.WriteLine($"{studentsAge.Key} - {studentsAge.Value}");
}
