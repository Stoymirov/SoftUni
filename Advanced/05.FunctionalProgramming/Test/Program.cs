
using System.ComponentModel;

static int Multiply(int a, int b, string text)
{
    return a * b;
}

Func<int> pointerToFunction = ReturnAnswerOfEverything;

Func<int, int, string, int> multiply = Multiply;

multiply(2, 2, "ko");
ReturnAnswerOfEverything();
static int ReturnAnswerOfEverything()
{
    return 42;
}