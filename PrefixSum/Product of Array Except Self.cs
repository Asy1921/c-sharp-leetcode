// 238. Product of Array Except Self
// Solved
// Medium
// Topics
// Companies
// Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

// The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

// You must write an algorithm that runs in O(n) time and without using the division operation.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] resultArr = new int[nums.Length];
        int i = 0;
        resultArr[0] = 1;
        int temp = 1;
        for (i = 0; i < nums.Length; i++)
        {
            resultArr[i] = temp;
            temp *= nums[i];
        }
        temp = 1;
        for (i = nums.Length - 1; i >= 0; i--)
        {
            resultArr[i] *= temp;
            temp *= nums[i];
        }
        return resultArr;

    }
}