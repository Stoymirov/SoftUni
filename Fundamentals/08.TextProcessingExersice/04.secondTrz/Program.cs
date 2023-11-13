string[] input = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);

foreach (var word in input)
{
    string[] letters = word.Split(' ',StringSplitOptions.RemoveEmptyEntries);
    foreach (var letter in letters)
    {
        char letterChar = GetLetter(letter);
        Console.Write(letterChar);
    }

    Console.Write(" ");
}








static char GetLetter(string morseCodeLetter)
{
    SortedDictionary<string, char> morseCode = new SortedDictionary<string, char>()
    {
        { ".-", 'A' },
        { "-...", 'B' },
        { "-.-.", 'C' },
        { "-..", 'D' },
        { ".", 'E' },
        { "..-.", 'F' },
        { "--.", 'G' },
        { "....", 'H' },
        { "..", 'I' },
        { ".---", 'J' },
        { "-.-", 'K' },
        { ".-..", 'L' },
        { "--", 'M' },
        { "-.", 'N' },
        { "---", 'O' },
        { ".--.", 'P' },
        { "--.-", 'Q' },
        { ".-.", 'R' },
        { "...", 'S' },
        { "-", 'T' },
        { "..-", 'U' },
        { "...-", 'V' },
        { ".--", 'W' },
        { "-..-", 'X' },
        { "-.--", 'Y' },
        { "--..", 'Z' }
    };
        return morseCode[morseCodeLetter];
        
}