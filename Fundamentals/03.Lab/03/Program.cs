double[] nums = Console.ReadLine()
    .Split(" ")
    .Select(double.Parse)
    .ToArray();

int[] roundedNumbers = new int[nums.Length];

for (int i = 0; i < nums.Length; i++)
{
    roundedNumbers[i] = (int)Math.Round(nums[i], MidpointRounding.AwayFromZero);
}
for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine($"{nums[i]} => {roundedNumbers[i]}");
}