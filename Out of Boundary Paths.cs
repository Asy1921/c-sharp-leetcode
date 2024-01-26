// 576. Out of Boundary Paths
// Solved
// Medium
// Topics
// Companies
// Hint
// There is an m x n grid with a ball. The ball is initially at the position [startRow, startColumn]. You are allowed to move the ball to one of the four adjacent cells in the grid (possibly out of the grid crossing the grid boundary). You can apply at most maxMove moves to the ball.

// Given the five integers m, n, maxMove, startRow, startColumn, return the number of paths to move the ball out of the grid boundary. Since the answer can be very large, return it modulo 109 + 7.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int FindPaths(int m, int n, int maxMove, int startRow, int startColumn)
    {
        int mod = 1000_000_000 + 7;

        Dictionary<(int, int, long), long> dp = new Dictionary<(int, int, long), long>();
        long checkAllPaths(int i, int j, long moves)
        {
            if (moves > maxMove)
            {
                return 0;
            }
            if (i < 0 || j < 0 || i >= m || j >= n)
            {

                return 1;
            }
            if (dp.ContainsKey((i, j, moves)))
            {
                return dp[(i, j, moves)];
            }
            long pathsFromHere =
            checkAllPaths(i + 1, j, moves + 1) +
            checkAllPaths(i, j + 1, moves + 1) +

            checkAllPaths(i - 1, j, moves + 1) +
            checkAllPaths(i, j - 1, moves + 1);
            dp.Add((i, j, moves), pathsFromHere % mod);
            return pathsFromHere % mod;

        }
        checkAllPaths(startRow, startColumn, 0);
        return (int)dp[(startRow, startColumn, 0)] % mod;
    }
}