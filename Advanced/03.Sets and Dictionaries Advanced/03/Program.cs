List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

input = input.OrderByDescending(x => x).Take(3).ToList();

foreach (var i in input)
{
    Console.Write(i+ " ");
}

;