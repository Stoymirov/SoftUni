string input = Console.ReadLine();
string command = "";
while ((command = Console.ReadLine()) != "Decode")
{
    string[] array = command.Split("|").ToArray();
    switch (array[0])
    {
        case "Move":
            int letterNumbers = int.Parse(array[1]);
            string substring = input.Substring(0, letterNumbers);
            input = input + substring;
            input = input.Remove(0, substring.Length);
            break;
        case "Insert":
            int index = int.Parse(array[1]);
           string value = (array[2]);
            input = input.Insert(index, value);
            break;
        case "ChangeAll":
            string substringa = array[1];
            string replacement = array[2];
            while (input.Contains(substringa))
            {
                input = input.Replace(substringa, replacement);
            }
            break;
    }
}

Console.WriteLine($"The decrypted message is: {input}");
