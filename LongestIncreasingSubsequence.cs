// 300.Longest Increasing Subsequence
// Medium
// 19.2K
// 361
// Companies
// Given an integer array nums, return the length of the longest strictly increasing 
// subsequence
// .A subsequence is an array that can be derived from another array by deleting some or no elements without changing the order of the remaining elements.



namespace LeetCodeProblems;
public partial class LCProblems
{
    public int LengthOfLIS(int[] nums)
    {
        int[] dp = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            dp[i] = 1;
        }
        for (int i = nums.Length - 2; i >= 0; i--)

        {
            for (int j = i; j < nums.Length; j++)
            {
                if (nums[i] < nums[j])
                {

                    dp[i] = Math.Max(dp[i], 1 + dp[j]);
                }

            }
        }
        return dp.Max();
    }
}