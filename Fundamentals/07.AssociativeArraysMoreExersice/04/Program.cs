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

foreach(var VARIABLE in myDictionary.OrderByDescending(x => x.Value.Count))
{
    foreach (var VARIABLE2 in VARIABLE.Value.Values.OrderByDescending(x => x.Physics).ThenBy(x => VARIABLE.Value.Count))
    {
        Console.WriteLine($"({VARIABLE.Key}) {VARIABLE2.Name} <-> {VARIABLE2.Physics}");
    }
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
