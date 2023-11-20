// 97. Interleaving String
// Medium
// 7.9K
// 450
// Companies
// Given strings s1, s2, and s3, find whether s3 is formed by an interleaving of s1 and s2.

// An interleaving of two strings s and t is a configuration where s and t are divided into n and m 
// substrings
//  respectively, such that:

// s = s1 + s2 + ... + sn
// t = t1 + t2 + ... + tm
// |n - m| <= 1
// The interleaving is s1 + t1 + s2 + t2 + s3 + t3 + ... or t1 + s1 + t2 + s2 + t3 + s3 + ...
// Note: a + b is the concatenation of strings a and b.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public bool IsInterleave(string s1, string s2, string s3)
    {
        if (s1.Length + s2.Length != s3.Length)
        {
            return false;
        }
        bool[,] dp = new bool[s1.Length + 1, s2.Length + 1];
        for (int i = s1.Length - 1; i >= 0; i--)
        {
            for (int j = s2.Length - 1; j >= 0; j--)
            { dp[i, j] = false; }
        }
        dp[s1.Length, s2.Length] = true;
        for (int i = s1.Length; i >= 0; i--)
        {
            for (int j = s2.Length; j >= 0; j--)
            {
                if (i < s1.Length && s1[i] == s3[i + j] && dp[i + 1, j])
                {
                    dp[i, j] = true;
                }
                if (j < s2.Length && s2[j] == s3[i + j] && dp[i, j + 1])
                {
                    dp[i, j] = true;
                }
            }
        }
        return dp[0, 0];
    }
}