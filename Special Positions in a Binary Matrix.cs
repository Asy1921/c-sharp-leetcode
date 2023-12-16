public class Solution {
    public int NumSpecial(int[][] mat) {
        int r = mat.Length;
        int c = mat[0].Length;

        int[] rowCounts = new int[r];
        int[] colCounts = new int[c];

        int res = 0;

        for (int i = 0; i < r; i++) {
            for (int j = 0; j < c; j++) {
                if (mat[i][j] == 1) {
                    rowCounts[i]++;
                    colCounts[j]++;
                }
            }
        }

        for (int i = 0; i < r; i++) {
            for (int j = 0; j < c; j++) {
                if (mat[i][j] == 1 && rowCounts[i] == 1 && colCounts[j] == 1) {
                    res++;
                }
            }
        }

        return res;
    }
}
