// 2441.Largest Positive Integer That Exists With Its Negative
// Solved
// Easy
// Topics
// Companies
// Hint
// Given an integer array nums that does not contain any zeros, find the largest positive integer k such that -k also exists in the array.

// Return the positive integer k. If there is no such integer, return -1.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int FindMaxK(int[] nums)
    {
        int res = -1;
        HashSet<int> set = new();

        foreach (int n in nums)
        {
            if (set.Contains(-n))
            {
                res = Math.Max(res, Math.Abs(n));

            }

            set.Add(n);

        }
        return res;
    }
}