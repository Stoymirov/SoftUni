﻿using System.Text;
//peter>2sis>1a>2akarate>4hexmaster

string input = Console.ReadLine();
StringBuilder sb = new StringBuilder();
int power = 0;
for (int i = 0; i < input.Length; i++)
{
    
    if (input[i] == '>')
    {
        power += int.Parse(input[i+1].ToString());
        sb.Append(input[i]);
        continue;
    }

    if (power > 0)
    {
        power--;
       
    }

    else if (power == 0)
    {
        sb.Append(input[i]);
    }
}

Console.WriteLine(sb);