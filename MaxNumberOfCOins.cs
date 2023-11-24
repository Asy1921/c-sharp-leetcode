// 1561. Maximum Number of Coins You Can Get
// Medium
// 1.7K
// 193
// Companies
// There are 3n piles of coins of varying size, you and your friends will take piles of coins as follows:

// In each step, you will choose any 3 piles of coins (not necessarily consecutive).
// Of your choice, Alice will pick the pile with the maximum number of coins.
// You will pick the next pile with the maximum number of coins.
// Your friend Bob will pick the last pile.
// Repeat until there are no more piles of coins.
// Given an array of integers piles where piles[i] is the number of coins in the ith pile.

// Return the maximum number of coins that you can have.

namespace LeetCodeProblems;

public partial class LCProblems
{
    public int MaxCoins(int[] piles)
    {
        Array.Sort(piles);
        int l = 0;
        int r = piles.Length - 1;
        int res = 0;
        while (l < r)
        {
            res += piles[r - 1];
            r -= 2;
            l++;
        }
        return res;
    }
}