using System.Text;

string input = Console.ReadLine();
StringBuilder sb = new StringBuilder();
sb.Append(input);
string command = "";
while ((command = Console.ReadLine()) != "Travel")
{
    string[] array = command.Split(":").ToArray();
    switch (array[0])
    {
        case "Add Stop":
            int index = int.Parse(array[1]);
            string stringa = array[2];
            if (index < 0 || index > input.Length-1)
            {
                Console.WriteLine(input);

                continue;
            }
            else
            {
                input = input.Insert(index, stringa);
                Console.WriteLine(input);
            }
            break;
        case "Remove Stop":
            int startIndex = int.Parse(array[1]);
            int endIndex = int.Parse(array[2]);
            if (startIndex < 0 || startIndex > input.Length - 1 || endIndex < 0 || endIndex > input.Length - 1)
            {
                Console.WriteLine(input);

                continue; 
            }
            else
            {
                input = input.Remove(startIndex, endIndex-startIndex+1);
                Console.WriteLine(input);
            }
            break;
        case "Switch":
            string oldString = array[1];
            string newString = array[2];
            if (input.Contains(oldString))
            {
                input = input.Replace(oldString, newString);
                Console.WriteLine(input);
            }
            else
            {
                Console.WriteLine(input);

                continue;
            }
            break;
    }
}

Console.WriteLine($"Ready for world tour! Planned stops: {input}");