// when treating the command as a newly registered check if there is this user in the side you are trying to add him in
Dictionary<string, HashSet<string>> sides = new Dictionary<string, HashSet<string>>();

string command = "";
while ((command = Console.ReadLine()) != "Lumpawaroo")
{
   
    string[] array = command.Split(new[] { " -> ", " | " }, StringSplitOptions.RemoveEmptyEntries);
    if (command.Contains("|"))
    {

        string side = array[0];
        string user = array[1];


        if (!sides.Values.Any(x => x.Contains(user)))
        {

            if (!sides.ContainsKey(side))
            {
                sides.Add(side, new HashSet<string>());
            }
            sides[side].Add(user);
        }



    }
    else if (command.Contains("->"))
    {
        string user = array[0];
        string side = array[1];

        foreach (var v in sides)
        {
            if (v.Value.Contains(user))
            {

                v.Value.Remove(user);
                break;
            }
        }


        if (!sides.ContainsKey(side))
        {
            sides.Add(side, new HashSet<string>());
        }
        sides[side].Add(user);
        Console.WriteLine($"{user} joins the {side} side!");


    }
}
foreach (var side in sides.Where(x => x.Value.Count != 0).OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
{
    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
    foreach (var VARIABLE in side.Value.OrderBy(x => x))
    {
        Console.WriteLine($"! {VARIABLE}");
    }
}