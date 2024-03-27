//930.Binary Subarrays With Sum
// Solved
// Medium
// Topics
// Companies
// Given a binary array nums and an integer goal, return the number of non-empty subarrays with a sum goal.

// A subarray is a contiguous part of the array.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int NumSubarraysWithSum(int[] nums, int goal)
    {
        int[] prefix = new int[nums.Length];
        prefix[0] = nums[0];
        int res = 0;
        if (prefix[0] == goal)
        {
            res++;
        }
        Dictionary<int, int> map = new();
        map.Add(prefix[0], 1);
        for (int i = 1; i < nums.Length; i++)
        {
            prefix[i] = nums[i] + prefix[i - 1];
            if (prefix[i] == goal)
            {
                res++;
            }
            if (map.ContainsKey(prefix[i] - goal))
            {
                res += map[prefix[i] - goal];
            }
            if (map.ContainsKey(prefix[i]))
            {
                map[prefix[i]]++;
            }
            else
            {
                map.Add(prefix[i], 1);
            }
        }

        return res;
    }
}