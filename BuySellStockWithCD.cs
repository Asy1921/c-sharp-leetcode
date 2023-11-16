// 309. Best Time to Buy and Sell Stock with Cooldown
// Medium
// 9K
// 299
// Companies
// You are given an array prices where prices[i] is the price of a given stock on the ith day.

// Find the maximum profit you can achieve. You may complete as many transactions as you like (i.e., buy one and sell one share of the stock multiple times) with the following restrictions:

// After you sell your stock, you cannot buy stock on the next day (i.e., cooldown one day).
// Note: You may not engage in multiple transactions simultaneously (i.e., you must sell the stock before you buy again).


using System.Runtime.Intrinsics.Arm;

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int MaxProfit(int[] prices)
    {
        Dictionary<(int, bool), int> hs = new Dictionary<(int, bool), int>();
        int dfs(int i, bool state)
        {
            if (i >= prices.Length)
            {
                return 0;
            }
            if (hs.ContainsKey((i, state)))
            {
                return hs[(i, state)];
            }

            int cd = dfs(i + 1, state);
            if (state == true)
            {
                int buy = dfs(i + 1, !state) - prices[i];
                hs[(i, state)] = Math.Max(buy, cd);
            }
            else
            {
                int sell = dfs(i + 2, !state) + prices[i];
                hs[(i, state)] = Math.Max(sell, cd);
            }
            return hs[(i, state)];
        }


        return dfs(0, true); ;
    }
}