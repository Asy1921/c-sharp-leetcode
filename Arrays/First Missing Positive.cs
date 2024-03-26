// 41.First Missing Positive
// Solved
// Hard
// Topics
// Companies
// Hint
// Given an unsorted integer array nums. Return the smallest positive integer that is not present in nums.

// You must implement an algorithm that runs in O(n) time and uses O(1) auxiliary space.

namespace LeetCodeProblems;

public partial class LCProblems
{
    public int FirstMissingPositive(int[] nums)
    {
        int n = nums.Length;
        for (int i = 0; i < n; i++)
        {
            if (nums[i] <= 0 || nums[i] > n)
            {
                nums[i] = n + 1;
            }

        }

        for (int i = 0; i < n; i++)
        {

            if (Math.Abs(nums[i]) > 0 && Math.Abs(nums[i]) <= n)
            {
                if (nums[Math.Abs(nums[i]) - 1] > 0)
                {
                    nums[Math.Abs(nums[i]) - 1] *= -1;
                }
            }

        }
        for (int i = 0; i < n; i++)
        {
            if (nums[i] > 0)
            {
                return i + 1;
            }

        }
        return n + 1;
    }
}