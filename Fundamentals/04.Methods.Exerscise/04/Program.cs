//write method for length of passord
//write method for only letters and digits
//write method for at least 2 digits 
using System.Reflection.Metadata.Ecma335;
using System.Transactions;

bool noMistakes = true;
string passwords = Console.ReadLine();
char[] password = passwords.ToArray();

if (!wrongLength(password))
{
    Console.WriteLine("Password must be between 6 and 10 characters");
    noMistakes = false;
}
if (!onlyLettersAndDigits(password))
{
    Console.WriteLine("Password must consist only of letters and digits");
    noMistakes = false;
}
if (!atLeast2Digits(password))
{
    Console.WriteLine("Password must have at least 2 digits");
    noMistakes = false;
}

if (noMistakes)
{
    Console.WriteLine("Password is valid");
}



static bool wrongLength(char[] password)

{
    if (password.Length < 6 || password.Length > 10)
    {

        return false;
    }
    else return true;
}

static bool onlyLettersAndDigits(char[] password)
{
    if (!password.All(char.IsLetterOrDigit))
    { return false;}
    return true;

}

static bool atLeast2Digits(char[] password)
{
    int digitsCounter = password.Count(char.IsDigit);
   
    if (digitsCounter < 2)
    {

        return false;

    }
    else return true;
}