string[] input = Console.ReadLine().Split(' ');

string string1 = input[0];
string string2 = input[1];

int result = 0;

int maxLength = Math.Max(string1.Length, string2.Length);
for (int i = 0; i < maxLength; i++)
{
    result += (i < string1.Length ? (string1[i] * string2[i]) : 0) +
              (i < string2.Length ? (string2[i] * string1[i]) : 0);
}