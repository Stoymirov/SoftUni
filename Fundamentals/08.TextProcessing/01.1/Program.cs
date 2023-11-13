string word = "";
while ((word = Console.ReadLine()) != "end")
{
    char[] array = word.Reverse().ToArray();
    Console.WriteLine($"{word} = {string.Join("",array)}");
}
 

