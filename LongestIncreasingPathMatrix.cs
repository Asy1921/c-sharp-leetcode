// 329. Longest Increasing Path in a Matrix
// Hard
// 8.6K
// 128
// Companies
// Given an m x n integers matrix, return the length of the longest increasing path in matrix.

// From each cell, you can either move in four directions: left, right, up, or down. You may not move diagonally or move outside the boundary (i.e., wrap-around is not allowed).
using System.Runtime.Intrinsics.Arm;

namespace LeetCodeProblems;

public partial class LCProblems
{
    public int LongestIncreasingPath(int[][] m)
    {
        int R = m.Length;
        int C = m[0].Length;
        Dictionary<(int, int), int> dp = new Dictionary<(int, int), int>();
        int res = 1;

        int dfs(int r, int c, int prev)
        {
            if (r < 0 || c < 0 || r == R || c == C || prev >= m[r][c])
            {
                return 0;
            }
            if (dp.ContainsKey((r, c)))
            {
                return dp[(r, c)];
            }
            int maxL = 1;
            maxL = Math.Max(maxL, 1 + dfs(r + 1, c, m[r][c]));
            maxL = Math.Max(maxL, 1 + dfs(r, c + 1, m[r][c]));
            maxL = Math.Max(maxL, 1 + dfs(r - 1, c, m[r][c]));
            maxL = Math.Max(maxL, 1 + dfs(r, c - 1, m[r][c]));
            dp.Add((r, c), maxL);
            res = Math.Max(maxL, res);
            return dp[(r, c)];

        }

        for (int i = 0; i < R; i++)
        {
            for (int j = 0; j < C; j++)
            {
                dfs(i, j, -1);
            }
        }
        return res;
    }
}