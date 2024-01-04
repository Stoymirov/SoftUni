
using System;
using System.Collections.Generic;
using System.Linq;
using ListyIterator;

List<string> items = Console.ReadLine().Split().Skip(1).ToList();
Console.WriteLine();
ListyIterator<string> listyIterator = new(items);
string command = "";
while ((command = Console.ReadLine()) != "END")
{
    switch (command)
    {
        case "Print":
            try
            {
                listyIterator.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;
        case "HasNext":
            Console.WriteLine(listyIterator.HasNext());
            break;
        case "Move":
            Console.WriteLine(listyIterator.Move());
            break;
        case "PrintAll":
            foreach (var item in listyIterator)
            {
                Console.WriteLine($"{item} ");
            }

            break;

    }
}