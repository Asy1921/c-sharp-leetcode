// 268.Missing Number
// Easy
// 11.1K
// 3.3K
// Companies
// Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array.
namespace LeetCodeProblems;

public partial class LCProblems
{
    public int MissingNumber(int[] nums)
    {

        return Enumerable.Range(0, nums.Length).Aggregate(nums.Length, (x, i) => x ^ i ^ nums[i]);
    }
}