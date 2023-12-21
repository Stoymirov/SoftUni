StreamReader reader = new StreamReader("../../../input.txt");

string input = reader.ReadToEnd();
Console.WriteLine(input);
reader.Close();

Console.WriteLine("the reader in already closed");