// 1685. Sum of Absolute Differences in a Sorted Array
// Medium
// 1.3K
// 39
// Companies
// You are given an integer array nums sorted in non-decreasing order.

// Build and return an integer array result with the same length as nums such that result[i] is equal to the summation of absolute differences between nums[i] and all the other elements in the array.

// In other words, result[i] is equal to sum(|nums[i]-nums[j]|) where 0 <= j < nums.length and j != i (0-indexed).
namespace LeetCodeProblems;
public partial class LCProblems
{
    public int[] GetSumAbsoluteDifferences(int[] nums)
    {
        int[] dp = new int[nums.Length], dif = new int[nums.Length];
        for (int i = 1; i < nums.Length; i++)
        {
            dp[0] += nums[i] - nums[0];
            dif[i] = nums[i] - nums[i - 1];
        }

        for (int i = 1; i < nums.Length; i++)
        {
            dp[i] = dp[i - 1] + i * dif[i] - (nums.Length - i) * dif[i];
        }
        return dp;

    }
}