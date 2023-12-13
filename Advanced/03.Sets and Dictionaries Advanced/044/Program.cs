Dictionary<string,Dictionary<string,int>> countries = new Dictionary<string,Dictionary<string,int>>()
{
    {"Bg",
        new Dictionary<string,int>()
        {
            {"Sofia",2},
            {"Plovdiv",2},
            {"Zagreb",2},
            {"wrtf",2},
            {"Sosfia",2}
        }

    },
    {
    "UK",
    new Dictionary<string,int>()
    {

    }
}
};
countries["Bg"]["Sofia"]+=10;

foreach (var country in countries)
{
    Console.WriteLine(country.Key+ " ");
    foreach (var c in country.Value)
    {
        Console.WriteLine($"{c.Key}:{c.Value}");
    }
}