using System.ComponentModel.Design;
using System.Xml.Serialization;

string command = "";
Dictionary<string, int> submissions = new Dictionary<string, int>();
Dictionary<string, int> grades = new Dictionary<string, int>();//language, submissions;name,points


while ((command = Console.ReadLine()) != "exam finished")
{
    string[] array = command.Split("-").ToArray();

    if (array.Length == 3)
    {

        string name = array[0];
        string language = array[1];
        int points = int.Parse(array[2]);

        if (!submissions.ContainsKey(language))
        {
            submissions.Add(language, 0);
        }
        submissions[language]++;

        if (grades.ContainsKey(name))
        {
            if (grades[name] < points)
            {
                grades.Remove(name);
            }
            else
            {
                continue;
            }
        }
        grades.Add(name, points);

    }
    else
    {

        string name = array[0];

        grades.Remove(name);
    }


}

Console.WriteLine("Results:");
foreach (var VARIABLE in grades.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
    
        Console.WriteLine($"{VARIABLE.Key} | {VARIABLE.Value}");
    
}

Console.WriteLine("Submissions:");
foreach (var submission in submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
    Console.WriteLine($"{submission.Key} - {submission.Value}");
}