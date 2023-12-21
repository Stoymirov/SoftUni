Dictionary<string,Dictionary<string,int>> clothes = new Dictionary<string, Dictionary<string, int>>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    string[] array = input.Split(new[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);

    string color = array[0];
    if (!clothes.ContainsKey(color))
    {
        clothes.Add(color,new Dictionary<string, int>());
    }
    for (int j = 1; j < array.Length; j++)
    {
        if (!clothes[color].ContainsKey(array[j]))
        {
            clothes[color].Add(array[j],0);
        }
        clothes[color][array[j]]++;
    }
}
string[] search = Console.ReadLine().Split();
string colorSearched = search[0];
string clothSearched = search[1];

foreach (var clothe in clothes)
{
    Console.WriteLine($"{clothe.Key} clothes:");
    foreach (var cloth in clothe.Value)
    {
        Console.Write($"* {cloth.Key} - {cloth.Value}");
        if (clothe.Key == colorSearched&&cloth.Key == clothSearched)
        {
            Console.Write(" (found!)");
        }

        Console.WriteLine();
    }
}