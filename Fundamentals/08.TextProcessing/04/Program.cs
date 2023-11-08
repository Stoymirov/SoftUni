using System.Diagnostics;

Stopwatch  sw = Stopwatch.StartNew();
sw.Start();
string text = "";
for (int i = 0; i < 200000; i++)
{
    text += i;
}
sw.Stop();
Console.WriteLine(sw.ElapsedMilliseconds);