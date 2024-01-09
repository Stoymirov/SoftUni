using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text;

string s = "hello";
Stopwatch  sw = new  Stopwatch();
sw.Start();
for (int i = 0; i < 100000; i++)
{
    s += "w";
}
sw.Stop();
Console.WriteLine(sw.ElapsedMilliseconds);

StringBuilder sb = new StringBuilder();
sw.Reset();
sw.Start();

for (int i = 0; i < 1000000; i++)
{
    sb.Append("s");
}

sw.Stop();
Console.WriteLine(sw.ElapsedMilliseconds);