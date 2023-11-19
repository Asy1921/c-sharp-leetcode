// 1887.Reduction Operations to Make the Array Elements Equal
// Medium
// 867
// 39
// Companies
// Given an integer array nums, your goal is to make all elements in nums equal. To complete one operation, follow these steps:

// Find the largest value in nums. Let its index be i (0-indexed) and its value be largest. If there are multiple elements with the largest value, pick the smallest i.
// Find the next largest value in nums strictly smaller than largest. Let its value be nextLargest.
// Reduce nums[i] to nextLargest.
// Return the number of operations to make all elements in nums equal.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int ReductionOperations(int[] nums)
    {
        Array.Sort(nums);
        Stack<(int key, int val)> s = new Stack<(int key, int val)>();
        foreach (int n in nums)
        {
            if (s.Count > 0 && s.Peek().key == n)
            {
                int temp = s.Peek().val + 1;
                s.Pop();
                s.Push((n, temp));
            }
            else
            {
                s.Push((n, 1));
            }
        }
        int res = 0;
        while (s.Count > 0)
        {
            res += s.Peek().val * (s.Count - 1);
            s.Pop();
        }
        return res;

    }
}