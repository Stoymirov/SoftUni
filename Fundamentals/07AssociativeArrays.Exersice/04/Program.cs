using System.Runtime.InteropServices.ComTypes;

int n = int.Parse(Console.ReadLine());
Dictionary<string, string> myMap = new Dictionary<string, string>();


for (int i = 0; i < n; i++)
{
    string licensePlateNumber = String.Empty;;
    List<string> input = Console.ReadLine().Split().ToList();

    string command = input[0];
    string username = input[1];
    if (input.Count == 3)
    { licensePlateNumber = input[2];
    }

    if (command == "register" && !myMap.ContainsKey(username))
    {
        myMap.Add(username, licensePlateNumber);
        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
    }

    else if (command == "register" && myMap.ContainsKey(username))
    {
        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
    }
    else if (command == "unregister" && myMap.ContainsKey(username))
    {
        myMap.Remove(username);
        Console.WriteLine($"{username} unregistered successfully");
    }
    else
    {
        Console.WriteLine($"ERROR: user {username} not found");
    }
}

foreach (var VARIABLE in myMap)
{
    Console.WriteLine($"{VARIABLE.Key} => {VARIABLE.Value}");
}

