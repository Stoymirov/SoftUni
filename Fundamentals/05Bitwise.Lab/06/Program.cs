int number = int.Parse(Console.ReadLine());
int p = int.Parse(Console.ReadLine());
int mask = 7 << p;// this is the number "number" just with some need changed so to use an operation later
int result = mask ^ number;//taking the result from the ^ operation
Console.WriteLine(result);
//110011
//101111