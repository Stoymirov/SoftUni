using Snake_game;

Snake snake = new Snake();
while (true)
{
    snake.WriteBoard();
    snake.Input();
    snake.Logic();
}

Console.ReadKey();