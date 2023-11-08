using System.Linq;

Dictionary<string, Dictionary<string, Dwarf>> myDictionary = new Dictionary<string, Dictionary<string,Dwarf>>();
    

string command = "";
while ((command = Console.ReadLine()) != "Once upon a time")
{
    string[] array = command.Split(" <:> ");
    string name = array[0];
    string color = array[1];
    int physics = int.Parse(array[2]);

    if (!myDictionary.ContainsKey(color))
    {
        myDictionary.Add(color, new Dictionary<string, Dwarf>());
    }

    if (myDictionary[color].ContainsKey(name))
    {
        if (myDictionary[color][name].Physics < physics)
        {
            myDictionary[color][name].Physics = physics;
        }
    }
    else
    {
        Dwarf newDwarf = new Dwarf(name, physics);
        myDictionary[color].Add(name,newDwarf);
    }
}


var sortedDwarfs = myDictionary
    .OrderByDescending(pair => pair.Value.Values.Max(dwarf => dwarf.Physics))
    .ThenByDescending(pair => pair.Value.Count)
    .SelectMany(pair => pair.Value.Values
        .OrderByDescending(dwarf => dwarf.Physics)
        .Select(dwarf => $"({pair.Key}) {dwarf.Name} <-> {dwarf.Physics}"));

foreach (var dwarf in sortedDwarfs)
{
    Console.WriteLine(dwarf);
}




class Dwarf
{
    public Dwarf(string name,int physics)
    {
        Name = name;
        Physics = physics;
       
    }
    public string Name { get; set; }
    public int Physics { get; set; }
  
}
