using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

Dictionary<string, Dictionary<string, Dragon>> myDictionary
    = new Dictionary<string, Dictionary<string, Dragon>>();

int[] basicStats = new int[3] { 45, 250, 10 };

int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    string type = input[0];
    string name = input[1];
    string damageString = input[2];
    string healthString = input[3];
    string armorString = input[4];

    int damage = damageString == "null" ? 45 : int.Parse(damageString);
    int health = healthString == "null" ? 250 : int.Parse(healthString);
    int armor = armorString == "null" ? 10 : int.Parse(armorString);


    if (!myDictionary.ContainsKey(type))
    {
        myDictionary[type] = new Dictionary<string, Dragon>();


    }

    if (!myDictionary[type].Keys.Contains(name))
    {
        Dragon dragon = new Dragon(name, damage, health, armor);
        myDictionary[type].Add(name, dragon);
    }
    else
    {
        Dragon theDragon = myDictionary[type][name];
        theDragon.Health = health;
        theDragon.Damage = damage;
        theDragon.Armor = armor;
    }


}
foreach (var item in myDictionary)
{
    Console.WriteLine($"{item.Key}::({item.Value.Values.Average(x => x.Damage):f2}/" +
                      $"{item.Value.Values.Average(x => x.Health):f2}/{item.Value.Values.Average(x => x.Armor):f2})");
    foreach (var VARIABLE in item.Value.OrderBy(x=>x.Key))
    {
        Console.WriteLine($"-{VARIABLE.Value.Name} -> damage: {VARIABLE.Value.Damage}, health: {VARIABLE.Value.Health}, armor: {VARIABLE.Value.Armor}");
    }
}





class Dragon
{
    public Dragon(string name, int damage, int health, int armor)
    {
        Name = name;
        Damage = damage;
        Health = health;
        Armor = armor;
    }
    public string Name { get; set; }
    public int Damage { get; set; }
    public int Health { get; set; }
    public int Armor { get; set; }


}

