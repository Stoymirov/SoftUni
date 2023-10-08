string intiger = Console.ReadLine();
int number = int.Parse(intiger);
char[] chars = intiger.ToCharArray();
int[] intArray = new int[chars.Length];
for (int i = 0; i < chars.Length; i++)
{
    intArray[i] = (int)chars[i] - 48;
}


for (int j = 1; j <= number; j++)
{
    string stringed = j.ToString();
    char[] chars1 = stringed.ToCharArray();
    int[] intArray1 = new int[chars1.Length];
    for (int i = 0; i < chars1.Length; i++)
    {
        intArray1[i] = (int)chars1[i] - 48;
    }


    int sum = 0;
    bool OddFound = false;
    for (int i = 0; i < intArray1.Length; i++)
    {
        sum += intArray1[i];
        if (intArray1[i] %2 !=0)
        {
            OddFound = true;
        }
    }
    if(sum%8 ==0 && OddFound)
    {
        Console.WriteLine(j);
    }
    
}