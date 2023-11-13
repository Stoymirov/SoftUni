
using System.Xml.XPath;

string input = Console.ReadLine();
string fileName = String.Empty;
string extension = String.Empty;

int index = input.LastIndexOf('\\');
fileName = input.Substring(index+1);
string[] array = fileName.Split('.');
fileName = array[0];
extension = array[1];
Console.WriteLine($"File name: {fileName}");
Console.WriteLine($"File extension: {extension}");