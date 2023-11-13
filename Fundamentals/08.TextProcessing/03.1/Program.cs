string keyWord = Console.ReadLine();
string  valueWord = Console.ReadLine();

while (valueWord.Contains(keyWord))
{
    int index = valueWord.IndexOf(keyWord);
    valueWord = valueWord.Remove(index,keyWord.Length);
}

Console.WriteLine(valueWord);
