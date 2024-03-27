// 713. Subarray Product Less Than K
// Solved
// Medium
// Topics
// Companies
// Hint
// Given an array of integers nums and an integer k, return the number of contiguous subarrays where the product of all the elements in the subarray is strictly less than k.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int NumSubarrayProductLessThanK(int[] nums, int k)
    {
        int l = 0;
        int r = 0;
        long product = 1;
        int res = 0;

        for (r = 0; r < nums.Length; r++)
        {
            product *= nums[r];
            while (l <= r && product >= k)
            {
                product /= nums[l];
                l++;
            }
            res += r - l + 1;
        }
        return res;
    }
}