List<int> input1 = new List<int> { 1, 2, 3, 4, 5 };
List<int> result1 = productExceptSelfWithoutDivision(input1);
Console.WriteLine(string.Join(", ", result1)); // [120, 60, 40, 30, 24]

List<int> input2 = new List<int> { 3, 2, 1 };
List<int> result2 = productExceptSelfWithoutDivision(input2);
Console.WriteLine(string.Join(", ", result2)); // [2, 3, 6]

List<int> productExceptSelfWithoutDivision(List<int> nums)
{
    int n = nums.Count;
    List<int> leftProducts = new List<int>(n); // Initialize with capacity
    List<int> rightProducts = new List<int>(n); // Initialize with capacity
    List<int> result = new List<int>(n); // Initialize with capacity

    int leftProduct = 1;
    int rightProduct = 1;

    // Calculate left products
    for (int i = 0; i < n; i++)
    {
        leftProducts.Add(leftProduct); // Add left product at index i
        leftProduct *= nums[i]; // Update left product for the next iteration
    }

    // Calculate right products
    for (int i = n - 1; i >= 0; i--)
    {
        rightProducts.Insert(0, rightProduct); // Insert right product at the beginning of the list
        rightProduct *= nums[i]; // Update right product for the next iteration
    }

    // Calculate the final result
    for (int i = 0; i < n; i++)
    {
        result.Add(leftProducts[i] * rightProducts[i]); // Calculate result at index i
    }

    return result;
}





















//using System.Collections.Generic;


//    List<int> input1 =new List<int> {1, 12, 3, 4, 5};
//    List<int> result1 = productExceptSelf(input1);
//    Console.WriteLine(result1); // [120, 60, 40, 30, 24]

//    List<int> input2 = new List<int> { 3,2,1};
//    List<int> result2 = productExceptSelf(input2);
//    Console.WriteLine(result2);
//     // [2, 3, 6]

//List<int> productExceptSelf(List<int> nums)
//{
//    int product = 1;
//    int zeroCount = 0;
//    int zeroIndex = -1;

//    for (int i = 0; i < nums.Count; i++)
//    {
//        if (nums[i] == 0)
//        {
//            zeroCount++;
//            zeroIndex = i;
//            continue;
//        }
//        product *= nums[i];
//    }

//    List<int> result = nums;

//    if (zeroCount == 1)
//    {
//        // If there's exactly one zero, set the product at the zero index
//        result[zeroIndex] = product;
//    }
//    else if (zeroCount == 0)
//    {
//        // If there are no zeros, calculate the product for each element
//        for (int i = 0; i < result.Count; i++)
//        {
//            result[i] = product / nums[i];
//        }
//    }

//    return result;
//}












//int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

//int[] newArray =  new int[array.Length];

//for (int i = 0; i < newArray.Length; i++)
//{
//    int currentProduct = 1;
//    for (int j = 0; j < newArray.Length; j++)
//    {
//        if (j != i)
//        {
//            currentProduct *= array[j];
//        }

//    }
//    newArray[i] = currentProduct;
//}

//Console.WriteLine(string.Join(" ",newArray));
