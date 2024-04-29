// 2996. Smallest Missing Integer Greater Than Sequential Prefix Sum
// Solved
// Easy
// Topics
// Companies
// Hint
// You are given a 0-indexed array of integers nums.

// A prefix nums[0..i] is sequential if, for all 1 <= j <= i, nums[j] = nums[j - 1] + 1. In particular, the prefix consisting only of nums[0] is sequential.

// Return the smallest integer x missing from nums such that x is greater than or equal to the sum of the longest sequential prefix.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int MissingInteger(int[] nums)
    {
        int sum = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1] + 1)
            {
                sum += nums[i];
            }
            else
            {
                break;
            }
        }
        while (true)
        {
            if (!nums.Contains(sum))
            {
                return sum;
            }
            else
            {
                sum++;
            }
        }
        return -1;

    }
}