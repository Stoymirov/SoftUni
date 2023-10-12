List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

List<int> result = new List<int>();
for (int i = 0; i < (numbers.Count / 2); i++)
{

    result.Add(numbers[i] + numbers[numbers.Count - 1 - i]);

}
if (numbers.Count % 2 == 0)
{
    Console.WriteLine(string.Join(" ", result));

}
else
{
    int middleindex = numbers.Count / 2;
    result.Add(numbers[middleindex]);
    Console.WriteLine(string.Join(" ", result));
}
