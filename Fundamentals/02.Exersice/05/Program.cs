int keyInteger = int.Parse(Console.ReadLine());
int LinesNumber =  int.Parse(Console.ReadLine());
string word = "";
for (int i = 0; i < LinesNumber; i++)
{
    char currentChar = char.Parse(Console.ReadLine());
    int numberOfChar = keyInteger + (int)currentChar;
    word += (char)numberOfChar;
}
Console.WriteLine(word);