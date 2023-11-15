// 1143.Longest Common Subsequence
// Medium
// 12.4K
// 158
// Companies
// Given two strings text1 and text2, return the length of their longest common subsequence. If there is no common subsequence, return 0.

// A subsequence of a string is a new string generated from the original string with some characters (can be none) deleted without changing the relative order of the remaining characters.

// For example, "ace" is a subsequence of "abcde".
// A common subsequence of two strings is a subsequence that is common to both strings.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int LongestCommonSubsequence(string text1, string text2)
    {
        int[,] dp = new int[text1.Length + 1, text2.Length + 1];
        for (int i = 0; i <= text1.Length; i++)
        {
            dp[i, text2.Length] = 0;
        }
        for (int j = 0; j <= text2.Length; j++)
        {
            dp[text1.Length, j] = 0;
        }
        for (int i = text1.Length - 1; i >= 0; i--)
        {
            for (int j = text2.Length - 1; j >= 0; j--)
            {
                if (text1[i] == text2[j])
                {
                    dp[i, j] = 1 + dp[i + 1, j + 1];
                }
                else
                {
                    dp[i, j] = Math.Max(dp[i + 1, j], dp[i, j + 1]);
                }
            }
        }
        return dp[0, 0];
    }
}