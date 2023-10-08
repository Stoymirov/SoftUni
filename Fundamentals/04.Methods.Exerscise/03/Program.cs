using System.Xml.Serialization;
int firstChar = (int)(char.Parse(Console.ReadLine()));
int secondChar = (int)(char.Parse(Console.ReadLine()));
PrintCharsInbetween(firstChar, secondChar);
static void PrintCharsInbetween(int firstChar, int secondChar)
{
    int firstcharacterUsed = firstChar;
    int secondcharachterUsed = secondChar;
    if (secondChar < firstChar)
    {
        secondChar = firstcharacterUsed;
        firstChar = secondcharachterUsed;
    }
    for (int i = firstChar + 1; i < secondChar; i++)
    {
        Console.Write((char)i + " ");
    }
}

