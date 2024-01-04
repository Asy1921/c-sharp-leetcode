// 2870.Minimum Number of Operations to Make Array Empty
// Medium
// 1K
// 51
// Companies
// You are given a 0-indexed array nums consisting of positive integers.

// There are two types of operations that you can apply on the array any number of times:

// Choose two elements with equal values and delete them from the array.
// Choose three elements with equal values and delete them from the array.
// Return the minimum number of operations required to make the array empty, or -1 if it is not possible.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int MinOperations(int[] nums)
    {
        int res = 0;
        Dictionary<int, int> map = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (map.ContainsKey(num)) map[num]++;
            else map.Add(num, 1);
        }

        foreach (int n in map.Values)
        {
            if (n == 1) return -1;

            res += n / 3;

            if (n % 3 == 1) res++;
            else res += (n % 3) / 2;
        }

        return res;
    }
}