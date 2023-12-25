// 643.Maximum Average Subarray I
// Easy
// 3.2K
// 267
// Companies
// You are given an integer array nums consisting of n elements, and an integer k.

// Find a contiguous subarray whose length is equal to k that has the maximum average value and return this value. Any answer with a calculation error less than 10-5 will be accepted.

namespace LeetCodeProblems;

public partial class LCProblems
{
    public double FindMaxAverage(int[] nums, int k)
    {
        double res = 0;
        int avg = 0;
        for (int i = 0; i < k; i++)
        {
            avg += nums[i];
        }
        res = (double)avg / k;
        for (int i = k; i < nums.Length; i++)
        {
            avg += nums[i] - nums[i - k];
            res = Math.Max(res, (double)avg / k);
        }
        return res;

    }
}
