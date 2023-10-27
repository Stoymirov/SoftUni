/*3
favourite_DownTown_3: 14
favourite_Kiss_4: 16
favourite_Smooth Criminal_4:01
favourite*/

int n = int.Parse(Console.ReadLine());

List<Song> songs = new List<Song>();

for (int i = 0; i < n; i++)
{
    string[] data = Console.ReadLine().Split("_");

    string type = data[0];
    string name = data[1];
    string time = data[2];
    Song song = new Song(type, name, time);
    // first way//Song song = new Song();// second way
 //song.TypeList = type;
                                           //song.Name = name;
                                           //song.Time = time;
                                           //Song song = new Song() { Name = name, TypeList = type, Time = time };// third way



    songs.Add(song);
}
string typeList = Console.ReadLine();

//if (typeList == "all")
//{
//    foreach (Song song in songs)
//    {
//        Console.WriteLine(song.Name);
//    }
//}
//else
//{
//    foreach (Song song in songs)
//    {


//        if (song.TypeList == typeList)    
//        {
//            Console.WriteLine(song.Name);
//        }
//    }

//}
//List<Song> filteredSongs = songs.Where(s=>s.TypeList == typeList).ToList();// 2-nd option
//Console.WriteLine(string.Join("\n", filteredSongs));
List<Song> mySongList = songs.Where(s => s.TypeList == typeList).ToList();
foreach (Song song in mySongList) 
{
    Console.WriteLine(song.Name);
}
//foreach (Song song in filteredSongs)
//{
//    Console.WriteLine(song.Name);
//}
class Song
{
    public Song()
    {

    }

    public Song(string TypeList, string Name, String Time)
    {
        this.TypeList = TypeList;
        this.Name = Name;
        this.Time = Time;
    }
    public string TypeList { set; get; }
    public string Name { set; get; }
    public string Time { set; get; }
}