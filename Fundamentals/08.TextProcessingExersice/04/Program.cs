using System.Diagnostics;
using System.Text;

string[] code = Console.ReadLine().Split("| ",StringSplitOptions.RemoveEmptyEntries);
code[^1] += " ";
string result = String.Empty;
foreach (var word in code)
{
    string currentletter = String.Empty;
    string currentWordNotCrypted = String.Empty;
    foreach (var character in word)
    {
        if (character != ' ')
        {
            currentletter += character;
        }
        else
        {
            switch (currentletter)
            {
                case ".-":
                    currentWordNotCrypted += "A";
                    break;
                case "-...":
                    currentWordNotCrypted += "B";
                    break;
                case "-.-.":
                    currentWordNotCrypted += "C";
                    break;
                case "-..":
                    currentWordNotCrypted += "D";
                    break;
                case ".":
                    currentWordNotCrypted += "E";
                    break;
                case "..-.":
                    currentWordNotCrypted += "F";
                    break;
                case "--.":
                    currentWordNotCrypted += "G";
                    break;
                case "....":
                    currentWordNotCrypted += "H";
                    break;
                case "..":
                    currentWordNotCrypted += "I";
                    break;
                case ".---":
                    currentWordNotCrypted += "G";
                    break;
                case "-.-":
                    currentWordNotCrypted += "K";
                    break;
                case ".-..":
                    currentWordNotCrypted += "L";
                    break;
                case "--":
                    currentWordNotCrypted += "M";
                    break;
                case "-.":
                    currentWordNotCrypted += "N";
                    break;
                case "---":
                    currentWordNotCrypted += "O";
                    break;
                case ".--.":
                    currentWordNotCrypted += "P";
                    break;
                case "--.-":
                    currentWordNotCrypted += "Q";
                    break;
                case ".-.":
                    currentWordNotCrypted += "R";
                    break;
                case "...":
                    currentWordNotCrypted += "S";
                    break;
                case "-":
                    currentWordNotCrypted += "T";
                    break;
                case "..-":
                    currentWordNotCrypted += "U";
                    break;
                case "...-":
                    currentWordNotCrypted += "V";
                    break;
                case ".--":
                    currentWordNotCrypted += "W";
                    break;
                case "-..-":
                    currentWordNotCrypted += "X";
                    break;
                case "-.--":
                    currentWordNotCrypted += "Y";
                    break;
                case "--..":
                    currentWordNotCrypted += "Z";
                    break;

            }//add the corresponding letter to the currentWOrdNotCrypted string.


            currentletter = String.Empty;
        }
    }

    result += currentWordNotCrypted + " ";
}

Console.WriteLine(result.Trim());
