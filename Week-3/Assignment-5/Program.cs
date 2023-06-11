using System;

class Program
{
  public static void Main(string[] args)
  {
    Console.WriteLine("Hello World");

    int[] result = twoSum(new int[] { 2, 7, 11, 15 }, 9);
    Console.WriteLine($"[{result[0]}, {result[1]}]");

    int[] result2 = twoSum(new int[] { 1, 1, 2, 1, 1, 2 }, 4);
    Console.WriteLine($"[{result2[0]}, {result2[1]}]");
  }


  // not familiar with dictionary, use the force solution.
  public static int[] twoSum(int[] nums, int target)
  {
    int[] result = new int[2];

    for (var i = 0; i < nums.Length; i++)
    {
      for (var j = i + 1; j < nums.Length; j++)
      {
        var diff = target - nums[i];
        if (nums[j] == diff)
        {
          result[0] = i;
          result[1] = j;
        }
      }
    }
    return result;
  }

  //// using Dictionary
  // public static int[] twoSum(int[] nums, int target)
  // {
  //   Dictionary<int, int> dict = new Dictionary<int, int>();
  //   for (var i = 0; i < nums.Length; i++)
  //   {
  //     int diff = target - nums[i];
  //     if (dict.ContainsKey(diff))
  //     {
  //       return new int[] { dict[diff], i };
  //     }
  //     if (!dict.ContainsKey(nums[i]))
  //     {
  //       dict.Add(nums[i], i);
  //     }
  //   }
  //   return new int[] { 0, 0 };
  // }
}