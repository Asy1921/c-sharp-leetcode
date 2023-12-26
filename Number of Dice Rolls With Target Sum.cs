// 1155. Number of Dice Rolls With Target Sum
// Medium
// 4.8K
// 159
// Companies
// You have n dice, and each die has k faces numbered from 1 to k.

// Given three integers n, k, and target, return the number of possible ways (out of the kn total ways) to roll the dice, so the sum of the face-up numbers equals target. Since the answer may be too large, return it modulo 109 + 7.
namespace LeetCodeProblems;
public partial class LCProblems
{
    public int NumRollsToTarget(int n, int k, int target)
    {
        int mod = 1000000000 + 7;
        Dictionary<(int, int), long> dp = new Dictionary<(int, int), long>();

        long calcWays(int sum, int rem)
        {
            if (dp.ContainsKey((sum, rem)))
            {
                return dp[(sum, rem)] % mod;
            }
            else if (sum == target && rem == 0)
            {
                return 1;
            }
            else if (sum > target || rem == 0)
            {
                return 0;
            }
            long ways = 0;
            for (int i = 1; i <= k; i++)
            {
                if (sum + i > target)
                {
                    break;
                }
                ways += calcWays(sum + i, rem - 1);
            }
            dp.Add((sum, rem), ways);
            return dp[(sum, rem)] % mod;

        }
        return (int)calcWays(0, n) % mod;



    }
}
