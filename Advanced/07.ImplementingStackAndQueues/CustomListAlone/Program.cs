
using CustomListAlone;

CustomList list = new CustomList();
list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);
Console.WriteLine(list.Contains(2));


list.InsertAt(0,15);
//list.RemoveAt(0);
//list.RemoveAt(0);
//list.RemoveAt(0);
;
Console.WriteLine(string.Join(" ",list));
