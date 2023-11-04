Dictionary<string, List<Person>> myDictionary = new Dictionary<string, List<Person>>();
Dictionary<string, int> pointsForEachCandidate = new Dictionary<string, int>();

string command = "";
while ((command = Console.ReadLine()) != "no more time")
{
    string[] array = command.Split(" -> ").ToArray();
    string name = array[0];
    string contest = array[1];
    int points = int.Parse(array[2]);
    
    if (!pointsForEachCandidate.ContainsKey(name))
    {
        pointsForEachCandidate.Add(name, 0);
    }

    if (!myDictionary.ContainsKey(contest))
    {
        myDictionary.Add(contest, new List<Person>());
    }

    var list = myDictionary[contest];
    var existingPerson = list.Find(x => x.Name == name);
    if (existingPerson == null)
    {
        list.Add(new Person(name,points));
    }
    else
    {
        if (existingPerson.Points < points)
        {
            existingPerson.Points = points;
        }
    }
}

foreach (var VARIABLE in myDictionary)
{
    foreach (var VARIABLE2 in VARIABLE.Value)
    {
        if (pointsForEachCandidate.ContainsKey(VARIABLE2.Name))
        {
            pointsForEachCandidate[VARIABLE2.Name] += VARIABLE2.Points;
        }
    }
}


foreach (var VARIABLE in myDictionary)
{
    Console.WriteLine($"{VARIABLE.Key}: {VARIABLE.Value.Count} participants");
    int n = 1;
    foreach (var variabel2 in VARIABLE.Value.OrderByDescending(x=>x.Points).ThenBy(x=>x.Name))
    {
        
        Console.WriteLine($"{n}. {variabel2.Name} <::> {variabel2.Points}");
        n++;
    }
}
int m = 1;
Console.WriteLine("Individual standings:");
foreach (var VARIABLE in pointsForEachCandidate.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
{
            Console.WriteLine($"{m}. {VARIABLE.Key} -> {VARIABLE.Value}");
    m++;
}

class Person
{
    public Person(string name, int points)
    {
        Name = name;
        Points = points;
    }
    public string Name { get; set; }
    public int Points { get; set; }

}