// 53. Maximum Subarray
// Medium
// 32.6K
// 1.4K
// Companies
// Given an integer array nums, find the 
// subarray
//  with the largest sum, and return its sum.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int MaxSubArray(int[] nums)
    {
        int sum = 0;
        int res = Int32.MinValue;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            res = Math.Max(res, sum);
            if (sum < 0)
            {
                sum = 0;
            }
        }

        return res;
    }
}