int[] nums = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] condesed = new int[nums.Length];


   
    for (int j = 0; j < nums.Length-1; j++)
    {


        for (int i= 0; i < nums.Length-1; i++)
        {
            condesed[i] = nums[i] + nums[i + 1];
        

        }
    
    nums = condesed;
    }
    if (nums.Length == 1)
{
    Console.WriteLine(nums[0]);
}
    else 

Console.WriteLine(condesed[0]);