// 907.Sum of Subarray Minimums
// Medium
// Topics
// Companies
// Given an array of integers arr, find the sum of min(b), where b ranges over every (contiguous) subarray of arr. Since the answer may be large, return the answer modulo 109 + 7.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int SumSubarrayMins(int[] arr)
    {
        long mod = 1000000000 + 7;
        int res = 0;
        int min = Int32.MaxValue;

        for (int i = 0; i < arr.Length; i++)
        {
            res += arr[i];
            for (int j = 0; j < i; j++)
            {
                res += arr[j..(i + 1)].Min();
            }
        }
        return (int)(res % mod);

    }
}
