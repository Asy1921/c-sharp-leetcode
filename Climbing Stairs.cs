
// Code
// Testcase
// Testcase
// Test Result
// 70. Climbing Stairs
// Solved
// Easy
// Topics
// Companies
// Hint
// You are climbing a staircase. It takes n steps to reach the top.

// Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

namespace LeetCodeProblems;
public partial class LCProblems
{
    int[] dp = new int[n + 1];
    dp[0]=1;
        dp[1]=1;
        for(int i=2;i<=n;i++)
        {
            dp[i]=0;
            for(int j=1;j<=2&&j<=i;j++)
            {
                dp[i]+=dp[i - j];
            }
        }
        return dp[n];
    }
}
