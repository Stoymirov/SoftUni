string intiger = string.Empty;
while ((intiger = Console.ReadLine()) != "END")
{
    char[] chars = intiger.ToCharArray();
    int[] intArray = new int[chars.Length];
    for (int i = 0; i < chars.Length; i++)
    {
        intArray[i] = (int)chars[i] - 48;
    }


    Console.WriteLine(IsTheNumberPalindrome(intArray));
}

static bool IsTheNumberPalindrome(int[] arr)
{
    int[] forwardArray = arr.ToArray();
    Array.Reverse(forwardArray);
    return arr.SequenceEqual(forwardArray);
}