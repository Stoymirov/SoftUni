List<string> myList = Console.ReadLine()
    .Split()
    .ToList();

string command = "";
while ((command = Console.ReadLine()) != "3:1")
{

    string[] commandArray = command.Split().ToArray();
    if (commandArray[0] == "divide")
    {
        int index = int.Parse(commandArray[1]);
        int partitions = int.Parse(commandArray[2]);

        string word = myList[index];
        char[] wordToCharArray = word.ToCharArray();
        int quotient = wordToCharArray.Length / partitions;//tells the number of number
        int remainer = wordToCharArray.Length % partitions;//remainer


        List<string> listToBeAdded = new List<string>();//list that i will insert
        int counter = 0;


        if (remainer <= quotient && remainer != 0)//if remainer is smaller we nned to make sure it is bigger
        {
            remainer += quotient;
            for (int i = 0; i < partitions - 1; i++)
            {

                string stringToAdd = "";
                int controlerForCounter = counter;
                for (int j = counter; j < controlerForCounter + quotient; j++)//we create each little sequence and add it to a list
                {
                    stringToAdd += wordToCharArray[j];
                    counter++;
                }
                listToBeAdded.Add(stringToAdd);
            }

            string stringTo = "";//we add the remainer
            int controlerCounter = counter;
            for (int i = counter; i < controlerCounter + remainer; i++)
            {
                stringTo += wordToCharArray[i];
                
                counter++;
            }
            listToBeAdded.Add(stringTo);
        }
        else if (remainer == 0)
        {
            for (int i = 0; i < partitions; i++)
            {
                int controlerCounter = counter;
                string stringToAdd = "";
                for (int j = counter; j < controlerCounter + quotient; j++)
                {
                    stringToAdd += wordToCharArray[j];
                    counter++;
                }
                listToBeAdded.Add(stringToAdd);
            }
        }

        myList.RemoveAt(index);
        myList.InsertRange(index, listToBeAdded);




        //if chastnoto e po golqmo ot ostatyka ostatyka plus chastnoto i chastnoto minus 1

    }
    else
    {
        int startIndex = int.Parse(commandArray[1]);
        int endIndex = int.Parse(commandArray[2]);
        if (endIndex > myList.Count - 1)
        {
            endIndex = myList.Count - 1;
        }
        if (startIndex < 0)
        {
            startIndex = 0;
        }

        string result = "";
        for (int i = startIndex; i <= endIndex; i++)
        {
            result += myList[i];
        }
        for (int i = startIndex; i <= endIndex; i++)
        {
            myList.RemoveAt(startIndex);
        }
        myList.Insert(startIndex, result);
    }

}

Console.WriteLine(string.Join(" ", myList));
