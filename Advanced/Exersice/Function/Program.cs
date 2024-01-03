//Combine miltiply = (x,y) => x*y;
//Combine add = (x,y) =>x+y;

//public delegate int Combine(int x, int y);


Func<int, int,int> multiplier = (a,b) => a * b;
Func<int, int,int> subtracter = (a,b) => a - b;
Func<int, int,int> sum = (a,b) => a + b;

static int Operation(int a, int b, Func<int, int, int> operation)
{
    Console.WriteLine("Operation is being calculated");
    return operation(a, b);
}

Console.WriteLine(Operation(2,3,sum));