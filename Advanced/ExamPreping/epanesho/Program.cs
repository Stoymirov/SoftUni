namespace TicTacToe
{
    internal class Program
    {
        public static char[] Numbers = { '@', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public static string UserInput = "";
        public static bool WinAchieved = false;
        public static int Turn = 1, Counter = 0;

        static void Main(string[] args)
        {
            Welcome(); //a welcome message

            while (!WinAchieved || Counter < 9) //Counter reaching 9 = all 9 spots are taken but no one won = tie
            {
                int result = 0;
                bool exceptionInput = false;
                Console.WriteLine($"Player {Turn} choose a field: ");
                UserInput = Console.ReadLine();
                try
                {
                    result = int.Parse(UserInput);
                }
                catch (Exception)
                {
                    exceptionInput = true;
                }
                if (exceptionInput || (result < 1 || result > 9)) // is input an invalid: char/string or number out of range?
                {
                    Console.WriteLine($"Invalid input! Player {Turn} please choose a number from 1 to 9!");
                    continue;
                }

                if (Numbers[result] != 'X' && Numbers[result] != 'O') //if valid input
                {
                    if (Turn == 1)
                    {
                        Numbers[result] = 'X';
                    }
                    else
                    {
                        Numbers[result] = 'O';
                    }
                    Counter++;
                }
                else //if field already taken
                {
                    Console.WriteLine($"That field is already marked! Make another choice player {Turn}!");
                    continue;
                }
                WinAchieved = CheckForWin();
                if (WinAchieved)
                {
                    UpdateBoard();
                    Console.WriteLine($"Congratulations, player {Turn}! You won!");
                    break;

                }
                else if (Counter == 9)
                {
                    UpdateBoard();
                    Console.WriteLine("It`s a tie!");
                    break;
                }
                Turn++;
                if (Turn > 2) // switching between players
                {
                    Turn = 1;
                }
                UpdateBoard();
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
    }
}