/*regex 1 [A-Za-z] - for taking all letters out
 * regex 2 \d+(.?)\d+ = for taking number.
 * regex 3 [\/*] - for multiplication and devision
 */

using System.Reflection;
using System.Text.RegularExpressions;
Dictionary<string, Demon> myDemons = new Dictionary<string, Demon>();
Regex regexForLetters = new Regex(@"[^\.0-9+\-*\/ ,]");
Regex regexForNumber = new Regex(@"(\+|\-|)\d+(\.\d+)?");
Regex regexForMD = new Regex(@"[\/*]");


string[] input = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
foreach (var name in input)
{
    int demonHealth = 0;
    double demonDamage = 0;
    MatchCollection letters = regexForLetters.Matches(name);
    MatchCollection numbers = regexForNumber.Matches(name);
    MatchCollection signs = regexForMD.Matches(name);

    string stringForAllLetters = "";
    foreach (var letterInTheName in letters)
    {
        stringForAllLetters += letterInTheName.ToString();

    }
    char[] charArray = stringForAllLetters.ToCharArray();
    foreach (var c in charArray)
    {
        demonHealth += (int)c;
    }

    foreach (var number in numbers)
    {
        string toString = number.ToString();
        demonDamage += double.Parse(toString);

    }

    foreach (var sign in signs)
    {
        string toString = sign.ToString();
        if (toString == "/")
        {
            demonDamage /= 2;
        }
        else
        {
            demonDamage *= 2;
        }
    }

    Demon demon = new Demon(demonHealth, demonDamage);
    myDemons.Add(name,demon);
}

foreach (var VARIABLE in myDemons.OrderBy(x=>x.Key))
{
    Console.WriteLine($"{VARIABLE.Key} - {VARIABLE.Value.Health} health, {VARIABLE.Value.Damage:f2} damage");
}
class Demon
{
    public Demon(int health, double damage)
    {
        Health = health;
        Damage = damage;
    }
    public int Health { get; set; }
    public double Damage { get; set; }
}