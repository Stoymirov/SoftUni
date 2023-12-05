using System;
using System.Text.RegularExpressions;

class SpellDecipher
{
    static void Main()
    {
        string spell = Console.ReadLine();

        while (true)
        {
            string command = Console.ReadLine();

            if (command == "Abracadabra")
                break;

            ExecuteCommand(ref spell, command);
        }
    }

    static void ExecuteCommand(ref string spell, string command)
    {
        string[] parts = command.Split(' ');

        switch (parts[0])
        {
            case "Abjuration":
                spell = spell.ToUpper();
                Console.WriteLine(spell);
                break;

            case "Necromancy":
                spell = spell.ToLower();
                Console.WriteLine(spell);
                break;

            case "Illusion":
                int index;
                char letter;

                if (int.TryParse(parts[1], out index) && index >= 0 && index < spell.Length && parts[2].Length == 1)
                {
                    letter = parts[2][0];
                    spell = spell.Remove(index, 1).Insert(index, letter.ToString());
                    Console.WriteLine("Done!");
                }
                else
                {
                    Console.WriteLine("The spell was too weak.");
                }
                break;

            case "Divination":
                string firstSubstring = parts[1];
                string secondSubstring = parts[2];

                if (spell.Contains(firstSubstring))
                {
                    spell = spell.Replace(firstSubstring, secondSubstring);
                    Console.WriteLine(spell);
                }
                break;

            case "Alteration":
                string substringToRemove = parts[1];

                if (spell.Contains(substringToRemove))
                {
                    spell = spell.Replace(substringToRemove, "");
                    Console.WriteLine(spell);
                }
                break;

            default:
                Console.WriteLine("The spell did not work!");
                break;
        }
    }
}