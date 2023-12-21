using System.ComponentModel.Design;

Dictionary<int,int> dic =  new Dictionary<int,int>();

int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
    if (!dic.ContainsKey(number))
    {
        dic.Add(number, 0);
    }
    dic[number]++;
}
int firstKeyWithEvenCount = dic.Single(x => x.Value % 2 == 0).Key;

// Print the first key where the value's count is even
Console.WriteLine(firstKeyWithEvenCount);