int n = int.Parse(Console.ReadLine());//number of symbols
string empty = string.Empty;
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    int lenghtInput = input.Length;
    int mainDigit = input[0] - '0';

    int offset = (mainDigit - 2) * 3;

    if (mainDigit == 8 || mainDigit == 9)
    {
        offset += 1;
    }
    int letterIntexNumber = (offset + lenghtInput - 1);
    char letterIndex = (char)(97 + letterIntexNumber);
     empty += letterIndex;
}
Console.WriteLine(empty);
