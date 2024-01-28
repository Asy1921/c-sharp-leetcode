// 724. Find Pivot Index
// Solved
// Easy
// Topics
// Companies
// Hint
// Given an array of integers nums, calculate the pivot index of this array.

// The pivot index is the index where the sum of all the numbers strictly to the left of the index is equal to the sum of all the numbers strictly to the index's right.

// If the index is on the left edge of the array, then the left sum is 0 because there are no elements to the left. This also applies to the right edge of the array.

// Return the leftmost pivot index. If no such index exists, return -1.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int PivotIndex(int[] nums)
    {
        int[] prefixSum = new int[nums.Length + 1];
        prefixSum[0] = 0;
        for (int i = 1; i <= nums.Length; i++)
        {
            prefixSum[i] = 0;

            prefixSum[i] = prefixSum[i - 1] + nums[i - 1];

        }
        int res = -1;
        for (int i = 1; i < prefixSum.Length; i++)
        {
            if (prefixSum[i - 1] == (prefixSum[prefixSum.Length - 1] - prefixSum[i]))
                return res = i - 1;
        }
        return res;
    }
}