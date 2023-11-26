using System.Runtime.InteropServices.ComTypes;
using System.Text.RegularExpressions;

int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    Regex regex = new Regex(@"@#+[A-Z][A-Za-z\d]{4,}[A-Z]@#+");
    Match match = regex.Match(input);
    if (match.Success)
    {
        string numbers = "";
        string matchTostring = match.ToString();
        foreach (var VARIABLE in matchTostring)
        {
            int number;
            if (int.TryParse(VARIABLE.ToString(), out number))
            {
                numbers += number.ToString();
            }

        }
        if (numbers != "")
            Console.WriteLine($"Product group: {numbers}");
        else
        {
            Console.WriteLine("Product group: 00");
        }
    }
    else
    {
        Console.WriteLine("Invalid barcode");
    }


}