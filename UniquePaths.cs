// 62. Unique Paths
// Medium
// 15.9K
// 420
// Companies
// There is a robot on an m x n grid.The robot is initially located at the top-left corner (i.e., grid[0][0]). The robot tries to move to the bottom-right corner (i.e., grid[m - 1][n - 1]). The robot can only move either down or right at any point in time.

// Given the two integers m and n, return the number of possible unique paths that the robot can take to reach the bottom-right corner.

// The test cases are generated so that the answer will be less than or equal to 2 * 109.

using System.Security.Principal;

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int UniquePaths(int m, int n)
    {
        int[,] dp = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                dp[i, j] = 1;
            }
        }

        for (int i = m - 2; i >= 0; i--)
        {
            for (int j = n - 2; j >= 0; j--)
            {
                dp[i, j] = dp[i + 1, j] + dp[i, j + 1];
            }
        }

        return dp[0, 0];

    }
}