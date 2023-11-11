// 322.Coin Change
// Medium
// 18K
// 408
// Companies
// You are given an integer array coins representing coins of different denominations and an integer amount representing a total amount of money.

// Return the fewest number of coins that you need to make up that amount. If that amount of money cannot be made up by any combination of the coins, return -1.

// You may assume that you have an infinite number of each kind of coin.
namespace LeetCodeProblems;
public partial class LCProblems
{
    public int CoinChange(int[] coins, int amt)
    {
        var dp = Enumerable.Repeat(amt + 1, amt + 1).ToArray();

        dp[0] = 0;

        for (var a = 1; a <= amt; a++)
        {
            foreach (var c in coins)
            {
                if (a - c >= 0)
                {
                    dp[a] = Math.Min(dp[a], 1 + dp[a - c]);
                }
            }
        }

        return dp[amt] == amt + 1
            ? -1
            : dp[amt];
    }
}