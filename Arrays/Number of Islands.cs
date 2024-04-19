// 200.Number of Islands
// Solved
// Medium
// Topics
// Companies
// Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's (water), return the number of islands.

// An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.



namespace LeetCodeProblems;
public partial class LCProblems
{
    public int NumIslands(char[][] grid)
    {
        int r = grid.Length;
        int c = grid[0].Length;

        int res = 0;

        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                if (grid[i][j] == '1')
                {
                    res++;
                    findIsland(i, j);
                }
            }
        }

        void findIsland(int i, int j)
        {
            if (i >= 0 && i < r && j >= 0 && j < c && grid[i][j] == '1')
            {
                grid[i][j] = '0';
                findIsland(i + 1, j);
                findIsland(i - 1, j);
                findIsland(i, j + 1);
                findIsland(i, j - 1);
            }
        }
        return res;
    }
}