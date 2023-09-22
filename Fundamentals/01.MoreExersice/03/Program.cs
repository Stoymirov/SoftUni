string input = Console.ReadLine();
string word = "";

for (int i = input.Length - 1; i >= 0; i--)
{
    word += input[i];
}
Console.WriteLine(word);