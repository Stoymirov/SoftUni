using System;

namespace Main
{
    class Program
    {

        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = "";
            while ((command = Console.ReadLine()) != "Reveal")
            {
                string[] array = command.Split(":|:").ToArray();
                switch (array[0])
                {
                    case "InsertSpace":
                        message = message.Insert(int.Parse(array[1]), " ");
                        Console.WriteLine(message);
                        break;
                    case "Reverse":

                        string substring = array[1];
                        if (message.Contains(substring))
                        {
                            int indexOfBegingSub = message.IndexOf(substring);
                            message = message.Remove(indexOfBegingSub, substring.Length);
                            string newString = new string(substring.Reverse().ToArray());
                            message += newString;
                            Console.WriteLine(message);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }

                        break;
                    case "ChangeAll":
                        string substringNew = array[1];
                        string replacement = array[2];
                        while (message.Contains(substringNew))
                        {
                            message = message.Replace(substringNew, replacement);
                        }

                        Console.WriteLine(message);
                        break;
                }
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}