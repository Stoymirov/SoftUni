using System.Diagnostics.Metrics;

string input = Console.ReadLine();

string command = "";
while ((command = Console.ReadLine()) != "Abracadabra")
{
    string[] array = command.Split().ToArray();
    switch (array[0])
    {
        case "Abjuration":
            input = input.ToUpper();
            Console.WriteLine(input);
            break;
        case "Necromancy":
            input = input.ToLower();
            Console.WriteLine(input);
            break;
        case "Illusion":
            int index = int.Parse(array[1]);
            char character = char.Parse(array[2]);

            if (index>input.Length-1 || index<0 )
            {
                Console.WriteLine("The spell was too weak.");
            }
            else
            {
                input = input.Replace(input[index], character);
                Console.WriteLine("Done!");
            }
            break;
        

        case "Divination":
            string substring1 = array[1];
            string substring2 = array[2];
            if (input.Contains(substring1))
            {

                input = input.Replace(substring1, substring2);

                Console.WriteLine(input);
            }
            break;
        case "Alteration":
            if (input.Contains(input[1]))
            {
                input = input.Replace(array[1], "");
                Console.WriteLine(input);
            }

            break;
        default:
            Console.WriteLine("The spell did not work!");
            break;
    }
}