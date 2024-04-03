
// Code
// Testcase
// Test Result
// Test Result
// 79. Word Search
// Solved
// Medium
// Topics
// Companies
// Given an m x n grid of characters board and a string word, return true if word exists in the grid.

// The word can be constructed from letters of sequentially adjacent cells, where adjacent cells are horizontally or vertically neighboring. The same letter cell may not be used more than once.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public bool Exists(char[][] board, string word)
    {

        bool dfs(int r, int c, int i, bool[,] vis)
        {
            if (i == word.Length)
            {
                return true;
            }
            if (r >= board.Length || c >= board[0].Length || i == word.Length || r < 0 || c < 0 || vis[r, c] || board[r][c] != word[i])
            {
                return false;
            }
            vis[r, c] = true;
            bool res = dfs(r + 1, c, i + 1, vis) || dfs(r - 1, c, i + 1, vis) || dfs(r, c + 1, i + 1, vis) || dfs(r, c - 1, i + 1, vis);
            vis[r, c] = false;
            return res;
        }

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                if (board[i][j] == word[0] && dfs(i, j, 0, new bool[board.Length, board[0].Length]))
                {
                    return true;
                }
            }
        }
        return false;
    }
}