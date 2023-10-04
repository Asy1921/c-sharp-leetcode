
// 287.Find the Duplicate Number
// Medium
// 21.6K
// 3.6K
// Companies
// Given an array of integers nums containing n + 1 integers where each integer is in the range [1, n] inclusive.

// There is only one repeated number in nums, return this repeated number.

// You must solve the problem without modifying the array nums and uses only constant extra space.
namespace LeetCodeProblems;
public partial class LCProblems
{
    public int FindDuplicate(int[] nums)
    {
        int s = 0;
        int f = 0;
        while (true)
        {
            s = nums[s];
            f = nums[nums[f]];
            if (s == f)
            {
                break;
            }
        }
        int s1 = 0;
        while (true)
        {
            s = nums[s];
            s1 = nums[s1];
            if (s1 == s)
            {
                return s1;
            }
        }
        return 0;
    }
}