//661. Image Smoother
//Easy
//1K
//2.8K
//Companies
//An image smoother is a filter of the size 3 x 3 that can be applied to each cell of an image by rounding down the average of the cell and the eight surrounding cells (i.e., the average of the nine cells in the blue smoother). If one or more of the surrounding cells of a cell is not present, we do not consider it in the average (i.e., the average of the four cells in the red smoother).
namespace LeetCodeProblems;

public partial class LCProblems{
 public int[][] ImageSmoother(int[][] img) {
        int m = img.Length;
        int n = img[0].Length;
        
        int[][] result = new int[m][];
        for (int i = 0; i < m; i++) {
            result[i] = new int[n];
        }

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                int total = 0;
                int count = 0;

                // Iterate over the 3x3 neighborhood
                for (int x = Math.Max(0, i - 1); x < Math.Min(m, i + 2); x++) {
                    for (int y = Math.Max(0, j - 1); y < Math.Min(n, j + 2); y++) {
                        total += img[x][y];
                        count++;
                    }
                }

                // Calculate the average and round down
                result[i][j] = total / count;
            }
        }

        return result;
    }
}
