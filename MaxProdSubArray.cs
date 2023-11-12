// 152.Maximum Product Subarray
// Medium
// 17.6K
// 557
// Companies
// Given an integer array nums, find a 
// subarray
//  that has the largest product, and return the product.

// The test cases are generated so that the answer will fit in a 32-bit integer.
namespace LeetCodeProblems;

public partial class LCProblems
{
    public int MaxProduct(int[] nums)
    {
        int res = nums.Max();
        int min = 1, max = 1;
        foreach (int n in nums)
        {
            int temp = max * n;

            max = new int[] { min * n, max * n, n }.Max();
            min = new int[] { temp, min * n, n }.Min();
            res = Math.Max(max, res);
        }
        return res;

    }
}