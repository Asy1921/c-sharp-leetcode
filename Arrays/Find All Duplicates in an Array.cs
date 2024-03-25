// 442. Find All Duplicates in an Array
// Solved
// Medium
// Topics
// Companies
// Given an integer array nums of length n where all the integers of nums are in the range [1, n] and each integer appears once or twice, return an array of all the integers that appears twice.

// You must write an algorithm that runs in O(n) time and uses only constant extra space.

namespace LeetCodeProblems;

public partial class LCProblems
{
    public IList<int> FindDuplicates(int[] nums)
    {
        List<int> res = new();
        foreach (int n in nums)
        {
            if (nums[Math.Abs(n) - 1] < 0)
            {
                res.Add(Math.Abs(n));
            }
            else
            {
                nums[Math.Abs(n) - 1] *= -1;
            }
        }
        return res;
    }
}