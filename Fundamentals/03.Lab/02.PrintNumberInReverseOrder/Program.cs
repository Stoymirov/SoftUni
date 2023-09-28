using System.Threading.Tasks.Dataflow;

int n = int.Parse(Console.ReadLine());
int[] ints = new int[n];

for (int i = n-1; i >= 0; i--)
{
    ints[i] = int.Parse(Console.ReadLine());

}
for (int i = 0; i < ints.Length; i++)
{
    Console.Write(ints[i] + " ");
}

//Console.WriteLine(string.Join(",", ints.Select( x=> x.ToString()).ToArray()));