static void VowelsCounter(char[] arr) 
{

    int vowelsCounter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        switch (arr[i])
        {
            case 'a':
            case 'e':
            case 'u':
            case 'i':
            case 'o':
            case 'A':
            case 'E':
            case 'U':
            case 'I':
            case 'O':
                vowelsCounter++;
                break;
        }
        
    }
    Console.WriteLine(vowelsCounter);
}
string word = Console.ReadLine();
char[] arr = word.ToCharArray();
VowelsCounter(arr);