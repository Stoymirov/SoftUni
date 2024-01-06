using Stack;

CustomStack<string> stack = new CustomStack<string>();

string command = "";
while ((command = Console.ReadLine()) != "END")
{
    string[] tokens = command.Split(new char[]{' ',','},StringSplitOptions.RemoveEmptyEntries);
    switch (tokens[0]) 
    {
        case "Push":

            foreach (var VARIABLE in tokens.Skip(1))
            {
                stack.Push(VARIABLE);
            }

            break;
        case "Pop":
            try
            {
                stack.Pop();
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            break;
    }

}

foreach (var VARIABLE in stack)
{
    Console.WriteLine(VARIABLE);
}foreach (var VARIABLE in stack)
{
    Console.WriteLine(VARIABLE);
}