﻿int n = int.Parse(Console.ReadLine());
int sum = 0;
while (n > 0)
{
    int lastDigit = n % 10;
    sum += lastDigit;
    n /= 10;
}
Console.WriteLine(sum);