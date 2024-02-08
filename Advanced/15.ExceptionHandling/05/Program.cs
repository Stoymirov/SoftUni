int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int exceptions = 0;
while (exceptions < 3)
{
    string[] inputNew = Console.ReadLine().Split();
    try
    {
        switch (inputNew[0])
        {
            case "Replace":
                int first = int.Parse(inputNew[1]);
                int second = int.Parse(inputNew[2]);
                if (first < 0 || first >= input.Length || second < 0 || second >= input.Length)
                {
                    throw new ArgumentOutOfRangeException("The index does not exist");
                }

                (first, second) = (second, first);
                break;
            case "Print":

        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        throw;
    }
}

void Validate()
{

}