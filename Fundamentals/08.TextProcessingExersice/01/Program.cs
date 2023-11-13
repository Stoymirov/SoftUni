int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    int indexofkliomba = input.IndexOf("@");
    int indexOfstraightline = input.IndexOf("|");
    string name = input.Substring(indexofkliomba+1,indexOfstraightline- indexofkliomba-1);

    int indexofhash= input.IndexOf("#");
    int indexOfstar = input.IndexOf("*");
    string age = input.Substring(indexofhash+1, indexOfstar- indexofhash-1);
    Console.WriteLine($"{name} is {age} years old.");

}