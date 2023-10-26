namespace LeetCodeProblems;
public partial class LCProblems
{
    public int NumFactoredBinaryTrees(int[] arr)
    {
        int mod = 1000000007;
        Array.Sort(arr);
        long count = 0;
        Dictionary<int, long> dp = new Dictionary<int, long>();

        for (int i = 0; i < arr.Length; i++)
        {
            dp[arr[i]] = 1;
            for (int j = 0; j < i; j++)
            {
                if (arr[i] % arr[j] == 0)
                {
                    int complement = arr[i] / arr[j];
                    if (dp.ContainsKey(complement))
                    {
                        dp[arr[i]] = (dp[arr[i]] + dp[arr[j]] * dp[complement]) % mod;
                    }
                }
            }
            count = (count + dp[arr[i]]) % mod;
        }
        return (int)(count % mod);
    }
}
