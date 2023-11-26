using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

string[] array = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
int turn = 1;
int counterOfPlays = 0;
WelcomeMethod();//welcomes
Console.ReadLine();
StartingBoard(array);
InstructionMethod(turn);//tells the player what to do

while (counterOfPlays < 9 )
{
    if(CheckForWin(array))
    {
        return;
    }
    string numberOfFieldChosenByPlayer = (Console.ReadLine());
    if (CheckForValid(numberOfFieldChosenByPlayer))
    {
        if (turn == 1)
        {
            if (array[int.Parse(numberOfFieldChosenByPlayer) - 1] != "X" && array[int.Parse(numberOfFieldChosenByPlayer) - 1] != "O")
            {

                array[int.Parse(numberOfFieldChosenByPlayer) - 1] = "X";
            }
            else
            {
                Console.WriteLine("Field already taken! Choose another one!");
                Console.WriteLine("Select new number...");
                continue;
            }
        }
        else
        {
            if ((array[int.Parse(numberOfFieldChosenByPlayer) - 1] != "O") && (array[int.Parse(numberOfFieldChosenByPlayer) - 1] != "X"))
            {

                array[int.Parse(numberOfFieldChosenByPlayer) - 1] = "O";
            }
            else
            {
                
                    Console.WriteLine("Fiend already taken! Choose another one!");
                    Console.WriteLine("Select new number...");
                    
                continue;
            }
        }
        ClearBoard();
        StartingBoard(array);
    
        turn++;
    if (turn > 2)
    {
        turn = 1;
    }
        InstructionMethod(turn);
    }


}

static void ClearBoard()
{
    Console.Clear();
}
static void WelcomeMethod()
{
    Console.WriteLine("Welcome!");
    Console.WriteLine("This is a TicTacToe game played on a console");
    Console.WriteLine("To begin press any key...");
}

static void InstructionMethod(int turn)
{
    if (turn == 1)
        Console.WriteLine("Player 1 to move");
    else Console.WriteLine("player 2 to move");
    Console.WriteLine("Press the digit to play");
}

static void StartingBoard(string[] array)
{
    Console.WriteLine("     |       |     ");
    Console.WriteLine($"  {array[0]}  |   {array[1]}   |   {array[2]}");
    Console.WriteLine("-----|-------|------");
    Console.WriteLine("     |       |     ");
    Console.WriteLine($"  {array[3]}  |   {array[4]}   |   {array[5]}");
    Console.WriteLine("-----|-------|------");
    Console.WriteLine("     |       |     ");
    Console.WriteLine($"  {array[6]}  |   {array[7]}   |   {array[8]}");
}

static bool CheckForValid(string input)
{
    bool isTrue = int.TryParse(input, out int value);//tries to parse int number
    if (!isTrue)
    {
        Console.WriteLine("Enter a number!");
        return false;
    }
    else
    {
        if (value < 1 || value > 9)
        {
            Console.WriteLine("Enter number between 1 and 9!");

            return false;
        }
 ;
        return true;
    }

}

static bool CheckForWin(string[] array)
{
    if (array[0] == array[1] && array[2] == array[1] || array[3] == array[4] && array[5] == array[4] || array[6] == array[7] && array[8] == array[7])
    {
        if (array[0] == "X")
        {
            Console.WriteLine("Player one wins!");
        }
        else Console.WriteLine("Player two wins!");

        return true;
    }
    else if (array[0] == array[3] && array[3] == array[6] || array[1] == array[4] && array[4] == array[7] ||
             array[2] == array[5] && array[5] == array[8])
    {
        if (array[0] == "X")
        {
            Console.WriteLine("Player one wins!");
        }
        else Console.WriteLine("Player two wins!");
        return true;
    }
    else if (array[0] == array[4] && array[4] == array[8] || array[2] == array[4] && array[4] == array[6])
    {
        if (array[0] == "X")
        {
            Console.WriteLine("Player one wins!");
        }
        else Console.WriteLine("Player two wins!");
        return true;
    }

    return false;
}