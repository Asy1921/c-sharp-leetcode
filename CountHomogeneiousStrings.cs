namespace LeetCodeProblems;
public partial class LCProblems
{
    public int CountHomogenous(string s)
    {
        const int MOD = 1000000007;
        int count = 0;
        int currentLength = 1;

        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == s[i - 1])
            {
                currentLength++;
            }
            else
            {
                count = (int)((count + (long)currentLength * (currentLength + 1) / 2) % MOD);
                currentLength = 1;
            }
        }

        count = (int)((count + (long)currentLength * (currentLength + 1) / 2) % MOD);

        return count;
    }
    public int CountAP(int n)
    {
        return (n * ((n + 1) / 2));
    }
}