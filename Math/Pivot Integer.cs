// 2485. Find the Pivot Integer
// Solved
// Easy
// Topics
// Companies
// Hint
// Given a positive integer n, find the pivot integer x such that:

// The sum of all elements between 1 and x inclusively equals the sum of all elements between x and n inclusively.
// Return the pivot integer x. If no such integer exists, return -1. It is guaranteed that there will be at most one pivot index for the given input.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int PivotInteger(int n)
    {
        int l = (n * (n + 1)) / 2;
        int r = 0;

        while (l > r)
        {
            r += n;
            if (r == l) return n;
            l -= n;
            n--;
        }

        return -1;
    }
}