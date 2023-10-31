// 779. K-th Symbol in Grammar
// Medium
// 3.4K
// 353
// Companies
// We build a table of n rows (1-indexed). We start by writing 0 in the 1st row. Now in every subsequent row, we look at the previous row and replace each occurrence of 0 with 01, and each occurrence of 1 with 10.

// For example, for n = 3, the 1st row is 0, the 2nd row is 01, and the 3rd row is 0110.
// Given two integer n and k, return the kth (1-indexed) symbol in the nth row of a table of n rows.
namespace LeetCodeProblems;
public partial class LCProblems
{
public int KthGrammar(int N, int K) {
        //0
        //01
        //0110
        //01101001
        //0110100110010110
        //123456789
         if (N == 1)
        {
            // Base case: When N is 1, the only element in the row is 0.
            return 0;
        }

        int mid = (int)Math.Pow(2, N - 1) / 2;
        
        if (K <= mid)
        {
            // If K is in the first half, it is the same as KthGrammar(N-1, K).
            return KthGrammar(N - 1, K);
        }
        else
        {
            // If K is in the second half, it is the complement of KthGrammar(N-1, K - mid).
            return 1 - KthGrammar(N - 1, K - mid);
        }
        
    }
}