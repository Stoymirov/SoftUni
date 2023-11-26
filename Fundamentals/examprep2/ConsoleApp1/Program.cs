namespace TicTacToeWithRestartAvailable
{
    internal class Program
    {
        public static char[] Numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public static string UserInput = "";
        public static bool WinAchieved = false, Restart = true;

        static void Main(string[] args)
        {

            while (Restart)
            {
                ResetBoard();
                int turn = 1, counter = 0;
                Welcome(); //welcome message
                while (!WinAchieved || counter < 9) //counter reaching 9 = all 9 spots are taken but no one won = tie
                {
                    int result = 0;
                    bool exceptionInput = false;
                    Console.WriteLine($"Player {turn} choose a field: ");
                    UserInput = Console.ReadLine();
                    try
                    {
                        result = int.Parse(UserInput);
                    }
                    catch (Exception)
                    {
                        exceptionInput = true;
                    }

                    if (exceptionInput || (result < 1 || result > 9)) // if input an invalid: char/string or number out of range?
                    {
                        Console.WriteLine($"Invalid input! Player {turn} please choose a number from 1 to 9!");
                        continue;
                    }

                    if (Numbers[result] != 'X' && Numbers[result] != 'O') //if valid input
                    {
                        if (turn == 1)
                        {
                            Numbers[result] = 'X';
                        }
                        else
                        {
                            Numbers[result] = 'O';
                        }
                        counter++;
                    }
                    else //if valid but field already taken
                    {
                        Console.WriteLine($"That field is already marked! Make another choice Player {turn}!");
                        continue;
                    }

                    WinAchieved = CheckForWin();
                    if (WinAchieved)
                    {
                        UpdateBoard();
                        Console.WriteLine($"Congratulations, Player {turn}! You win!");
                        break;

                    }
                    else if (counter == 9)
                    {
                        UpdateBoard();
                        Console.WriteLine("It`s a tie!");
                        break;
                    }

                    turn++;
                    if (turn > 2) // switching between players
                    {
                        turn = 1;
                    }
                    UpdateBoard();
                }
                RestartOrEnd();
            }

        }
        public static bool CheckForWin()
        {
            if ((Numbers[1] == Numbers[2] && Numbers[1] == Numbers[3]) || (Numbers[4] == Numbers[5] && Numbers[4] == Numbers[6])
                || (Numbers[7] == Numbers[8] && Numbers[7] == Numbers[9])) // checks rows
            { return true; }
            else if ((Numbers[1] == Numbers[4] && Numbers[1] == Numbers[7]) || (Numbers[2] == Numbers[5] && Numbers[2] == Numbers[8])
                || (Numbers[3] == Numbers[6] && Numbers[3] == Numbers[9])) //checks columns
            { return true; }
            else if ((Numbers[1] == Numbers[5] && Numbers[1] == Numbers[9])
                || (Numbers[3] == Numbers[5] && Numbers[3] == Numbers[7])) //checks diagonals
            { return true; }
            else
            { return false; }
        }
        public static void SetBoard()
        {
            Console.WriteLine("      |      |      ");
            Console.WriteLine($"  {Numbers[1]}   |  {Numbers[2]}   |  {Numbers[3]}  ");
            Console.WriteLine("______|______|______");
            Console.WriteLine("      |      |      ");
            Console.WriteLine($"  {Numbers[4]}   |  {Numbers[5]}   |  {Numbers[6]}  ");
            Console.WriteLine("______|______|______");
            Console.WriteLine("      |      |      ");
            Console.WriteLine($"  {Numbers[7]}   |  {Numbers[8]}   |  {Numbers[9]}  ");
            Console.WriteLine("      |      |      ");
        }
        public static void ResetBoard() //to initial state with Numbers
        {
            for (int i = 0; i < 10; i++)
            {
                char valueChar = (char)(i + '0');
                Numbers[i] = valueChar;
            }
        }
        public static void Welcome()
        {
            Console.WriteLine("Welcome! Let`s play some Tic Tac Toe!");
            Console.WriteLine("Player 1 is using X to mark!");
            Console.WriteLine("Player 2 is using O to mark!");
            Console.WriteLine("Good luck!");
            Console.WriteLine("Press any key to start the game: ");
            Console.Read();
            UpdateBoard();

        }
        public static void UpdateBoard()
        {
            Console.Clear();
            SetBoard();
        }
        public static void RestartOrEnd()
        {
            Console.WriteLine("Do you want to Restart the game?");
            Console.WriteLine("Press any key to Restart or \"Q\" to quit:");

            var key = Console.ReadKey();
            if (key.KeyChar == 'q' || key.KeyChar == 'Q')
            {
                Restart = false;
            }
            else
            {
                Console.Clear();

            }
        }
    }
}
