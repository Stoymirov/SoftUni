int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());
Console.WriteLine(FinalResult(n1, n2, n3));
static int FinalResult(int n1, int n2, int n3)
{
    int finalResult = (SumOfAll(n1,n2) - n3);
    return finalResult;
}
static int SumOfAll(int n1, int n2)
{
    int finalResult = n1 + n2;
    return finalResult;
}