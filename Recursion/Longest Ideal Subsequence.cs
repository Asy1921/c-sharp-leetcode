// 2370.Longest Ideal Subsequence
// Solved
// Medium
// Topics
// Companies
// Hint
// You are given a string s consisting of lowercase letters and an integer k. We call a string t ideal if the following conditions are satisfied:

// t is a subsequence of the string s.
// The absolute difference in the alphabet order of every two adjacent letters in t is less than or equal to k.
// Return the length of the longest ideal string.

// A subsequence is a string that can be derived from another string by deleting some or no characters without changing the order of the remaining characters.

// Note that the alphabet order is not cyclic. For example, the absolute difference in the alphabet order of 'a' and 'z' is 25, not 1.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int LongestIdealString(string s, int k)
    {
        int n = s.Length;
        int[,] cache = new int[27, n];

        for (int i = 0; i < 27; i++)
            for (int j = 0; j < n; j++) cache[i, j] = -1;

        return FindSubS(0, 26);


        int FindSubS(int i, int prev)
        {
            if (i == n) return 0;

            if (cache[prev, i] != -1) return cache[prev, i];

            // we skip current char
            int maxIdeal = FindSubS(i + 1, prev);

            // we add current char if its <= 'k' distance apart from last char 
            if (prev == 26 || Math.Abs(prev - (s[i] - 'a')) <= k)
                maxIdeal = Math.Max(maxIdeal, 1 + FindSubS(i + 1, s[i] - 'a'));


            return cache[prev, i] = maxIdeal;

        }
    }
}