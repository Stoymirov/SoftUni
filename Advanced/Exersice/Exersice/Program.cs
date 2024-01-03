Predicate<int> predicate = i =>
    {
        List<int> list = new List<int>();
        while (i != 0)
        {
            list.Add(i % 10);
            i /= 10;
        }

        List<int> firstHalf = new List<int>();
        List<int> secondHalf = new List<int>();
        if (list.Count % 2 == 0)
        {
            for (int j = 0; j < list.Count % 2; j++)
            {
                firstHalf.Add(list[j]);
            }

            for (int j = list.Count - 1; j >= list.Count / 2; j--)
            {
                secondHalf.Add(list[j]);
            }
        }
        else
        {
            for (int j = 0; j < (list.Count-1) / 2; j++)
            {
                firstHalf.Add(list[j]);
            }

            for (int j = list.Count - 1; j >= (list.Count+1) / 2 ; j--)
            {
                secondHalf.Add(list[j]);
            }
        }

        return firstHalf.SequenceEqual(secondHalf);
    }
    ;
Console.WriteLine(predicate(121));