    int efficiency1 = int.Parse(Console.ReadLine());
    int efficiency2 = int.Parse(Console.ReadLine());
    int efficiency3 = int.Parse(Console.ReadLine());
    int studentsCount = int.Parse(Console.ReadLine());

    int totalStudentServicedFor1Hour = efficiency1 + efficiency2 + efficiency3;

    double timeNeeded = Math.Ceiling(studentsCount / (double)totalStudentServicedFor1Hour);
    double neededTimeButForForCycle = timeNeeded;

    for (int i = 1; i < neededTimeButForForCycle / 3; i++)
    {
        timeNeeded++;
    }
    Console.WriteLine($"Time needed: {timeNeeded}h.");