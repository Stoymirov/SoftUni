string texts = Console.ReadLine();
PrintMiddle(texts);
static void PrintMiddle(string texts)
{
    char[] text = texts.ToCharArray();

    
    if (text.Length % 2 == 0)
    {
        char firstchar = text[text.Length / 2 - 1];
        char secondchar = text[text.Length / 2];
        Console.Write($"{firstchar}{secondchar}");
    }
    else
    {
        char firstchar = text[(text.Length +1) / 2 -1];
        Console.WriteLine(firstchar);
    }
}
