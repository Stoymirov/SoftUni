int n = int.Parse(Console.ReadLine());

double biggest = double.MinValue;
string biggestKeg = "";
for (int i = 0; i < n; i++)
{
    string model = Console.ReadLine();
    double radius = double.Parse(Console.ReadLine());
    double height = double.Parse(Console.ReadLine());
    double volume = Math.PI*radius*radius*height;
    if (volume > biggest)
    {
        biggestKeg = model;
        biggest = volume;
    }
}
Console.WriteLine(biggestKeg);


/*3
Keg 1
10
10
Keg 2
20
20
Keg 3
10
30
*/