public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }

        return new int[] { };
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the Number: ");
        string input = Console.ReadLine()!;

        string[] values = input.Split(' ');

        int[] nums = new int[values.Length];

        for (int i = 0; i < values.Length; i++)
        {
            nums[i] = int.Parse(values[i]);
        }

        Console.Write("Enter the Target: ");
        int target = int.Parse(Console.ReadLine()!);

        Solution solution = new Solution();

        int[] result = solution.TwoSum(nums, target);

        Console.WriteLine($"[{result[0]}, {result[1]}]");
    }
}