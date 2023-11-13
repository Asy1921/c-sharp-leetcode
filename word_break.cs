// 139.Word Break
// Medium
// 16.4K
// 714
// Companies
// Given a string s and a dictionary of strings wordDict, return true if s can be segmented into a space-separated sequence of one or more dictionary words.

// Note that the same word in the dictionary may be reused multiple times in the segmentation.
namespace LeetCodeProblems;
public partial class LCProblems
{
    public bool WordBreak(string s, IList<string> wordDict)
    {
        bool[] dp = new bool[s.Length + 1];
        for (int i = 0; i < s.Length; i++)
        {
            dp[i] = false;
        }
        dp[s.Length] = true;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            foreach (string word in wordDict)
            {
                if (i + word.Length <= s.Length && s.Substring(i, word.Length) == word)
                {
                    dp[i] = dp[i + word.Length];
                }
                if (dp[i])
                {
                    break;
                }
            }
        }
        return dp[0];
    }
}