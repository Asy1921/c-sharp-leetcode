// 198.House Robber
// Medium
// 19.5K
// 367
// Companies
// You are a professional robber planning to rob houses along a street. Each house has a certain amount of money stashed, the only constraint stopping you from robbing each of them is that adjacent houses have security systems connected and it will automatically contact the police if two adjacent houses were broken into on the same night.

// Given an integer array nums representing the amount of money of each house, return the maximum amount of money you can rob tonight without alerting the police.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int Rob(int[] n)
    {
        if (n.Length == 1)
        {
            return n[0];
        }
        if (n.Length == 2)
        { return Math.Max(n[0], n[1]); }
        int v1 = n[0];
        int v2 = Math.Max(n[0], n[1]);
        int tot = 0;
        for (int i = 2; i < n.Length; i++)
        {
            tot = Math.Max(n[i] + v1, v2);
            v1 = v2;
            v2 = tot;
        }
        return tot;

    }
}