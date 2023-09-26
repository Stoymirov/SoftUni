int linesNumber = int.Parse(Console.ReadLine());
int controlCounter = 0;

string answer = "";
for (int i = 0; i < linesNumber; i++)
{
    string input = Console.ReadLine();

    if (input == "(")
    {
        controlCounter++;
    }
    else if (input == ")")
    {
        controlCounter--;
    }
    if (answer != "UNBALANCED")
    {
        if (controlCounter < 0 || controlCounter > 1)
        {
            answer = "UNBALANCED";
        }
    }
}

if (answer == "UNBALANCED" || controlCounter == 1)
{
    Console.WriteLine("UNBALANCED");
}
else
{
    Console.WriteLine("BALANCED");
}