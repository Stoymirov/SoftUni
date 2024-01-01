using System;
using System.Linq;
using Threeuple;

string[] personTokens = Console.ReadLine().Split(' ');
string[] drinkTokens = Console.ReadLine().Split(' ');
string[] numbersTokens = Console.ReadLine().Split(' ');

CustomTuple<string, string,string> PersonTuple =
    new CustomTuple<string, string,string>(personTokens[0] +" "+ personTokens[1], personTokens[2], string.Join(" ", personTokens[3..]));
CustomTuple<string, double,bool> drinkTuple = new CustomTuple<string, double,bool>(drinkTokens[0], int.Parse(drinkTokens[1]), drinkTokens[2] == "drunk");
CustomTuple<string, double,string> numbersTuple =
    new CustomTuple<string, double,string>((numbersTokens[0]), double.Parse(numbersTokens[1]), numbersTokens[2]);
Console.WriteLine(PersonTuple);
Console.WriteLine(drinkTuple);
Console.WriteLine(numbersTuple);