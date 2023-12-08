Stack<char> characters = new Stack <char>();
string input = Console.ReadLine ();
foreach (var VARIABLE in input)
{
    characters.Push(VARIABLE);
}

while (characters.Count > 0)
{
    Console.Write(characters.Pop());
}