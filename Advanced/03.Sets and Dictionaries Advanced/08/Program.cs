using System;
using System.Collections;
using System.Collections.Generic;
HashSet<string> members =  new HashSet<string>();
HashSet<string> membersVIP =  new HashSet<string>();

string command ="";
while ((command = Console.ReadLine()) != "PARTY")
{
    if (char.IsDigit(command[0]))
    {
        membersVIP.Add(command);
    }
    else
    {
        members.Add(command);
    }
}

while ((command = Console.ReadLine()) != "END")
{
    members.Remove(command);
    membersVIP.Remove(command);
}

Console.WriteLine(members.Count+membersVIP.Count);
foreach (var VARIABLE in membersVIP)
{
    Console.WriteLine(VARIABLE);
}

foreach (var member in members)
{
    Console.WriteLine(member);
}