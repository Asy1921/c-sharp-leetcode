// 2958.Length of Longest Subarray With at Most K Frequency
// Solved
// Medium
// Topics
// Companies
// Hint
// You are given an integer array nums and an integer k.

// The frequency of an element x is the number of times it occurs in an array.

// An array is called good if the frequency of each element in this array is less than or equal to k.

// Return the length of the longest good subarray of nums.

// A subarray is a contiguous non-empty sequence of elements within an array.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int MaxSubarrayLength(int[] nums, int k)
    {
        Dictionary<int, int> map = new();
        int l = 0; int r = 0;
        int res = 0;

        //Loop till k clause is broken
        //then find which digit breaks the clause and move the left pointer to that point
        // Keep storing max len of subarray

        while (l <= r && r < nums.Length)
        {
            if (map.ContainsKey(nums[r]))
            {
                map[nums[r]]++;
            }
            else
            {
                map.Add(nums[r], 1);
            }

            //Move left pointer after
            while (map[nums[r]] > k)
            {
                map[nums[l++]]--;

            }
            res = Math.Max(r - l + 1, res);
            r++;

        }
        return res;
    }
}
