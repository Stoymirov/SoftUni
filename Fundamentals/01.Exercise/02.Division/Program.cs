//you will be given an integer, write a program which checks if the given integer is divisible by 2 or 3, or 6, or 7, or 10
//without a remainder. you should always take the bigger division:
//• if the number is divisible by both 2, 3, and 6, you should print the division by 6 only. 
//• if a number is divisible by 2 and 10, you should print the division by 10. 
//if the number is not divisible by any of the given numbers, print "not divisible". otherwise, print "the 
//number is divisible by {number}".
//examples
//input output
//30 the number is divisible by 10
//15 the number is divisible by 3
//12 the number is divisible by 6
//1643 not divisible

int n = int.Parse(Console.ReadLine());
if  (n % 10 == 0)
{
    Console.WriteLine("The number is divisible by 10");
}
else if (n % 7 == 0)
{
    Console.WriteLine("The number is divisible by 7");
}
else if (n % 6 == 0)
{
    Console.WriteLine("The number is divisible by 6");
}
else if (n % 3 == 0)
{
    Console.WriteLine("The number is divisible by 3");
}
else if (n % 2 == 0)
{
    Console.WriteLine("The number is divisible by 2");
}
else Console.WriteLine("Not divisible");