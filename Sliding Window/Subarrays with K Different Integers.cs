// 992. Subarrays with K Different Integers
// Hard
// Topics
// Companies
// Given an integer array nums and an integer k, return the number of good subarrays of nums.

// A good array is an array where the number of different integers in that array is exactly k.

// For example, [1,2,3,1,2] has 3 different integers: 1, 2, and 3.
// A subarray is a contiguous part of an array.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int SubarraysWithKDistinct(int[] nums, int k)
    {
        Dictionary<int, int> map = new();
        int ln = 0;
        int lf = 0;
        int r = 0;
        int res = 0;
        while (r < nums.Length)
        {
            if (map.ContainsKey(nums[r]))
            {
                map[nums[r]]++;
            }
            else
            {
                map.Add(nums[r], 1);
            }

            while (map.Count > k)
            {
                //Moving the near and far pointer
                map[nums[ln]]--;
                if (map[nums[ln]] == 0)
                {
                    map.Remove(nums[ln]);
                }
                ln++;
                lf = ln;
            }

            while (map[nums[ln]] > 1)
            {
                //We can move the near pointer
                map[nums[ln]]--;
                ln++;
            }

            if (map.Count == k)
            {
                res += ln - lf + 1;
            }
            r++;
        }
        return res;
    }
}