string[] array = Console.ReadLine().Split();

double resut = 0;

foreach (var word in array)
{
    double currentResult = 0;
    int firstChar= word[0];
    int lastChar = word[^1];
    int number = int.Parse(word.Substring(1, word.Length-2));
    if (firstChar < 97)
    {
        firstChar -=64;
        currentResult = number / (double)firstChar;

    }
    else
    {
        firstChar -= 96;
        currentResult = number * (double)firstChar;
    }

    if (lastChar < 97)
    {
        lastChar -= 64;
        currentResult -= lastChar;
    }
    else
    {
        lastChar -= 96;
        currentResult += lastChar;
    }

    resut += currentResult;
}

Console.WriteLine($"{resut:f2}");