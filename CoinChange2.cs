// 518.Coin Change II
// Medium
// 8.9K
// 154
// Companies
// You are given an integer array coins representing coins of different denominations and an integer amount representing a total amount of money.

// Return the number of combinations that make up that amount. If that amount of money cannot be made up by any combination of the coins, return 0.

// You may assume that you have an infinite number of each kind of coin.

// The answer is guaranteed to fit into a signed 32-bit integer.

namespace LeetCodeProblems;
public partial class LCProblems
{
    // Memoization
    public int Change(int amount, int[] coins)
    {
        int res = 0;
        int n = coins.Length;
        Dictionary<(int, int), int> cache = new Dictionary<(int, int), int>();

        int dfs(int i, int sum)
        {
            if (sum == amount)
            {

                return 1;
            }

            if (i >= n || sum > amount)
            {
                return 0;
            }
            if (cache.ContainsKey((i, sum)))
                return cache[(i, sum)];


            cache.Add((i, sum), dfs(i, sum + coins[i]) + dfs(i + 1, sum));
            return cache[(i, sum)];


        }

        return dfs(0, 0);

    }

    // DP
    public int ChangeDP(int amount, int[] coins)
    {
        int[,] dp = new int[coins.Length + 1, amount + 1];

        // Initialize the first column to 1
        for (int i = 0; i <= coins.Length; i++)
        {
            dp[i, 0] = 1;
        }

        for (int i = 1; i <= coins.Length; i++)
        {
            for (int j = 1; j <= amount; j++)
            {
                dp[i, j] = dp[i - 1, j];
                if (j - coins[i - 1] >= 0)
                {
                    dp[i, j] += dp[i, j - coins[i - 1]];
                }
            }
        }

        return dp[coins.Length, amount];
    }
}