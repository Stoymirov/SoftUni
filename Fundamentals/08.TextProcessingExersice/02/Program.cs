char firstChar = char.Parse(Console.ReadLine());
char secondChar = char.Parse(Console.ReadLine());
string input =  Console.ReadLine();
int result = 0;
for (int i = 0; i < input.Length; i++)
{
    char inputChar = input[i];
    if (inputChar < secondChar && inputChar > firstChar)
    {
        result += inputChar;
    }
}

Console.WriteLine(result);