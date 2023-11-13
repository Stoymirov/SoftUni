using System.Xml.XPath;

//string[] input = Console.ReadLine().Split();
//string firstString = input[0];
//string secondString = input[1];

//Console.WriteLine(MethodisMine(firstString,secondString));


//static int MethodisMine(string firstString, string secondString)
//{
//    int firstStringLegth = firstString.Length;
//    int secondStringLength = secondString.Length;
//    int result = 0;
//    int maxLength = Math.Max(firstString.Length, secondString.Length);
//    for (int i = 0; i < maxLength; i++)
//    {
//        if (firstStringLegth <= i)
//        {
//            result += secondString[i];
//        }
//        else if (secondStringLength <= i)
//        {
//            result += firstString[i];
//        }
//        else
//        {
//            result += firstString[i] * secondString[i];
//        }
//    }

//    return result;

//}
using System;

string[] input = Console.ReadLine().Split(' ');

string string1 = input[0];
string string2 = input[1];

int result = 0;

int maxLength = Math.Max(string1.Length, string2.Length);
for (int i = 0; i < maxLength; i++)
{
    result += string1.Length > i && string2.Length>i ? string1[i] * string2[i] : string2.Length > i ? string2[i] : string1[i];
   
}

System.Console.WriteLine(result);