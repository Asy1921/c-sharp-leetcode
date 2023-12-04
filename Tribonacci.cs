// 1137. N-th Tribonacci Number
// Easy
// 3.9K
// 173
// Companies
// The Tribonacci sequence Tn is defined as follows: 

// T0 = 0, T1 = 1, T2 = 1, and Tn+3 = Tn + Tn+1 + Tn+2 for n >= 0.

// Given n, return the value of Tn.
namespace LeetCodeProblems;
public partial class LCProblems
{
    public int Tribonacci(int n)
    {
        if (n <= 2)
        {
            if (n < 2)
            {
                return n;
            }
            else
            {
                return 1;
            }
        }
        int[] dp = new int[n];
        dp[0] = 0;
        dp[1] = 1;
        dp[2] = 1;
        for (int i = 3; i < n; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2] + dp[i - 3];
        }

        return dp[n - 3] + dp[n - 2] + dp[n - 1];
    }
    // 0 1 1 2 3 5 8 13
}