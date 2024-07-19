// 1380.Lucky Numbers in a Matrix
// Solved
// Easy
// Topics
// Companies
// Hint
// Given an m x n matrix of distinct numbers, return all lucky numbers in the matrix in any order.

// A lucky number is an element of the matrix such that it is the minimum element in its row and maximum in its column.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public IList<int> LuckyNumbers(int[][] matrix)
    {
        int r = matrix.Length;
        int c = matrix[0].Length;
        int[] RowMin = new int[r];
        int[] ColMax = new int[c];

        //Rows
        for (int i = 0; i < r; i++)
        {
            int min = int.MaxValue;
            for (int j = 0; j < c; j++)
            {
                if (matrix[i][j] < min)
                {
                    min = matrix[i][j];
                }
            }
            RowMin[i] = min;
        }
        //Cols
        for (int i = 0; i < c; i++)
        {
            int max = int.MinValue;
            for (int j = 0; j < r; j++)
            {
                if (matrix[j][i] > max)
                {
                    max = matrix[j][i];
                }
            }
            ColMax[i] = max;
        }

        List<int> res = new();
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                if (matrix[i][j] == RowMin[i] && matrix[i][j] == ColMax[j])
                {
                    res.Add(matrix[i][j]);
                }
            }

        }

        return res;
    }
}




