List<int> nums = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
List<char> chars = new List<char>();
chars.AddRange(Console.ReadLine());
for (int i = 0; i < nums.Count; i++)
{
    int sum = 0;
    int currentnumber = nums[i];
    while (currentnumber != 0)
    {
        sum += currentnumber % 10;
        currentnumber /= 10;
    }
    int timesRepeated = sum / chars.Count;
    sum = sum-timesRepeated*chars.Count;
    Console.Write(chars[sum]);
    chars.RemoveAt(sum);
}
