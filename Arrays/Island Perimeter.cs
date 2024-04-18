
// Code
// Testcase
// Testcase
// Test Result
// 463. Island Perimeter
// Solved
// Easy
// Topics
// Companies
// You are given row x col grid representing a map where grid[i][j] = 1 represents land and grid[i][j] = 0 represents water.

// Grid cells are connected horizontally/vertically (not diagonally). The grid is completely surrounded by water, and there is exactly one island (i.e., one or more connected land cells).

// The island doesn't have "lakes", meaning the water inside isn't connected to the water around the island. One cell is a square with side length 1. The grid is rectangular, width and height don't exceed 100. Determine the perimeter of the island.
namespace LeetCodeProblems;
public partial class LCProblems
{
    public int IslandPerimeter(int[][] grid)
    {
        int perimeter = 0;
        int rows = grid.Length;
        int cols = grid[0].Length;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (grid[i][j] == 1)
                {
                    perimeter += 4;

                    // Check adjacent cells
                    if (i > 0 && grid[i - 1][j] == 1) // Up
                        perimeter--;
                    if (i < rows - 1 && grid[i + 1][j] == 1) // Down
                        perimeter--;
                    if (j > 0 && grid[i][j - 1] == 1) // Left
                        perimeter--;
                    if (j < cols - 1 && grid[i][j + 1] == 1) // Right
                        perimeter--;
                }
            }
        }

        return perimeter;
    }
}