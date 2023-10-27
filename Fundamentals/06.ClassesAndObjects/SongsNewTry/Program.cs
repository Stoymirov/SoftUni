int n = int.Parse(Console.ReadLine());
List<Song> list = new List<Song>();

for (int i = 0; i < n; i++)
{
    string[] array = Console.ReadLine().Split("_").ToArray();
    string type = array[0];
    string name = array[1];
    string time = array[2];

Song song = new Song(type, name, time);
    list.Add(song);
}

string typeRequired = Console.ReadLine();

if(typeRequired =="all")
{
    Console.WriteLine(string.Join(Environment.NewLine, list.Select(x=>x.Name)));
}
else
{
    Console.WriteLine(string.Join(Environment.NewLine, list.Where(y=>y.TypeList == typeRequired).Select(x => x.Name)));
}

class Song
{
   public Song (string type, string name, string time)
    {
        TypeList = type;
        Name = name;
        Time = time;
    }
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }
}