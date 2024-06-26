// 3075. Maximize Happiness of Selected Children
// Solved
// Medium
// Topics
// Companies
// Hint
// You are given an array happiness of length n, and a positive integer k.

// There are n children standing in a queue, where the ith child has happiness value happiness[i]. You want to select k children from these n children in k turns.

// In each turn, when you select a child, the happiness value of all the children that have not been selected till now decreases by 1. Note that the happiness value cannot become negative and gets decremented only if it is positive.

// Return the maximum sum of the happiness values of the selected children you can achieve by selecting k children.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public long MaximumHappinessSum(int[] h, int k)
    {
        //There is no happiness
        long sum = 0;
        int d = 0;
        Array.Sort(h);
        for (int i = h.Length - 1; d < k; i--)
        {
            sum += Math.Max(h[i] - d, 0);
            d++;
        }
        return sum;
    }
}