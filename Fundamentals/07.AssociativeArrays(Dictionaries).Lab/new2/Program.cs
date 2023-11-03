string[] myArray = Console.ReadLine().Split();

Dictionary<string,int> count  = new Dictionary<string,int>();

foreach (var value in myArray)
{
   string valueInLowerCase = value.ToLower();
    if (count.ContainsKey(valueInLowerCase))
    {
        count[valueInLowerCase]++;
    }
    else
    {
        count.Add(valueInLowerCase,1);
    }
}

Console.WriteLine(string.Join(" ",count.Where(x=>x.Value%2!=0).Select(w=>w.Key)));