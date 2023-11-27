using System.Diagnostics.CodeAnalysis;

int n = int.Parse(Console.ReadLine());
Dictionary<string,Hero> heroes = new Dictionary<string,Hero>();


for (int i = 0; i < n; i++)
{
    string[] heroInfo = Console.ReadLine().Split(" ").ToArray();
    if (!heroes.ContainsKey(heroInfo[0]))
    {
        Hero hero = new Hero(int.Parse(heroInfo[1]), int.Parse(heroInfo[2]));
        heroes.Add(heroInfo[0], hero);
    }
    
}

string command = "";
while ((command = Console.ReadLine()) != "End")
{
    string[] array = command.Split(" - ").ToArray();
    switch (array[0])
    {
        case "CastSpell":
            CastSpellMethod(heroes, array);
            break;
        case "TakeDamage":
            TakenDamageMethod(heroes, array);
            break;

        case "Recharge":
            RechargeMethod(heroes, array);
            break;
        case "Heal":
            HealMethod(heroes, array);
            break;
    }
}

foreach (var VARIABLE in heroes)
{
    Console.WriteLine(VARIABLE.Key);
    Console.WriteLine($"  HP: {VARIABLE.Value.HP}");
    Console.WriteLine($"  MP: {VARIABLE.Value.MP}");
}

void CastSpellMethod(Dictionary<string, Hero> dictionary, string[] strings)
{
    if (dictionary[strings[1]].MP >= int.Parse(strings[2]))
    {
        dictionary[strings[1]].MP -= int.Parse(strings[2]);
        Console.WriteLine(
            $"{strings[1]} has successfully cast {strings[3]} and now has {dictionary[strings[1]].MP} MP!");
    }
    else
    {
        Console.WriteLine($"{strings[1]} does not have enough MP to cast {strings[3]}!");
    }
}

void TakenDamageMethod(Dictionary<string, Hero> heroes1, string[] array1)
{
    if (heroes1[array1[1]].HP > int.Parse(array1[2]))
    {
        heroes1[array1[1]].HP -= int.Parse(array1[2]);
        Console.WriteLine(
            $"{array1[1]} was hit for {array1[2]} HP by {array1[3]} and now has {heroes1[array1[1]].HP} HP left!");
    }
    else
    {
        Console.WriteLine($"{array1[1]} has been killed by {array1[3]}!");
        heroes1.Remove(array1[1]);
    }
}

void RechargeMethod(Dictionary<string, Hero> dictionary1, string[] strings1)
{
    if (dictionary1[strings1[1]].MP + int.Parse(strings1[2]) > 200)
    {
        Console.WriteLine($"{strings1[1]} recharged for {200 - (dictionary1[strings1[1]].MP)} MP!");
        dictionary1[strings1[1]].MP = 200;
    }
    else
    {
        Console.WriteLine($"{strings1[1]} recharged for {strings1[2]} MP!");
        dictionary1[strings1[1]].MP += int.Parse(strings1[2]);
    }
}

void HealMethod(Dictionary<string, Hero> heroes2, string[] array2)
{
    if (heroes2[array2[1]].HP + int.Parse(array2[2]) > 100)
    {
        Console.WriteLine($"{array2[1]} healed for {100 - (heroes2[array2[1]].HP)} HP!");
        heroes2[array2[1]].HP = 100;
    }
    else
    {
        Console.WriteLine($"{array2[1]} healed for {array2[2]} HP!");
        heroes2[array2[1]].HP += int.Parse(array2[2]);
    }

    return;
}

class Hero
{
    public Hero(int hp, int mp)
    {
        HP = hp;
        MP = mp;
    }
    public int HP { get; set; }
    public int MP { get; set; }
}