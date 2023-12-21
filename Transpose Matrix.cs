// 867. Transpose Matrix
// Easy
// 3.3K
// 433
// Companies
// Given a 2D integer array matrix, return the transpose of matrix.

// The transpose of a matrix is the matrix flipped over its main diagonal, switching the matrix's row and column indices.
namespace LeetCodeProblems;
public partial class LCProblems
{

    public int[][] Transpose(int[][] matrix)
    {
        int[][] res = new int[matrix[0].Length][];
        for (int i = 0; i < matrix[0].Length; i++)
        {
            res[i] = new int[matrix.Length];
            for (int j = 0; j < matrix.Length; j++)
            {
                res[i][j] = matrix[j][i];
            }

        }
        return res;
    }

}