using System.Text;

string input = Console.ReadLine();
Console.WriteLine(Encrypt(input));



static string Encrypt(string input)
{
    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < input.Length; i++)
    {
        char c = input[i];
        sb.Append((char)(c+3));
    }

 

    return sb.ToString();
}





















//string[] array = Console.ReadLine().Split();
//string result = String.Empty;
//for (int i = 0; i < array.Length; i++)
//{
//  string currentWord = array[i];
//  int changableVariable = 0;
//  foreach (var VARIABLE in currentWord)
//  {
//      changableVariable = (int)VARIABLE + 3;
//      result+=(char)changableVariable;
//  }
//  if(i!=array.Length-1)
//  result += '#';
//}

//Console.WriteLine(result);


