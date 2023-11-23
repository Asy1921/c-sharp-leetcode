// 115.Distinct Subsequences
// Hard
// 6.3K
// 279
// Companies
// Given two strings s and t, return the number of distinct subsequences of s which equals t.

// The test cases are generated so that the answer fits on a 32-bit signed integer.
namespace LeetCodeProblems;

public partial class LCProblems
{
    public int NumDistinct(string s, string t)
    {
        Dictionary<(int, int), int> dp = new Dictionary<(int, int), int>();
        int dfs(int i, int j)
        {
            if (s.Length - i < t.Length - j)
            { return 0; }
            if (j == t.Length)
            {
                return 1;
            }
            if (i == s.Length)
            {
                return 0;
            }
            if (dp.ContainsKey((i, j)))
            {
                return dp[(i, j)];
            }
            if (s[i] == t[j])
            {
                dp.Add((i, j), dfs(i + 1, j + 1) + dfs(i + 1, j));
            }
            else
            {
                dp.Add((i, j), dfs(i + 1, j));
            }
            return dp[(i, j)];
        }
        return dfs(0, 0);
    }
}