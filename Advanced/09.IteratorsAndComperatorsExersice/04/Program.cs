    
using System;
using System.Collections.Generic;
using System.Linq;
using Froggy;

List<int> stones = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
Lake lake = new Lake(stones);

    Console.WriteLine(string.Join(", ", lake));
    
