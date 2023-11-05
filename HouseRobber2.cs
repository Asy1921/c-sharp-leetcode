// 213.House Robber II
// Medium
// 9.3K
// 133
// Companies
// You are a professional robber planning to rob houses along a street. Each house has a certain amount of money stashed. All houses at this place are arranged in a circle. That means the first house is the neighbor of the last one. Meanwhile, adjacent houses have a security system connected, and it will automatically contact the police if two adjacent houses were broken into on the same night.

// Given an integer array nums representing the amount of money of each house, return the maximum amount of money you can rob tonight without alerting the police.
namespace LeetCodeProblems;
public partial class LCProblems
{
    public int Rob2(int[] n)
    {
        if (n.Length == 1)
        { return n[0]; }

        int rob(int[] arr)
        {
            int r1 = 0;
            int r2 = 0;
            foreach (int row in arr)
            {
                int nr = Math.Max(r1 + row, r2);
                r1 = r2;
                r2 = nr;
            }
            return r2;
        }
        return Math.Max(rob(n[0..(n.Length - 1)]), rob(n[1..(n.Length)]));
    }
}