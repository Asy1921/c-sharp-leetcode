
// 75.Sort Colors
// Solved
// Medium
// Topics
// Companies
// Hint
// Given an array nums with n objects colored red, white, or blue, sort them in-place so that objects of the same color are adjacent, with the colors in the order red, white, and blue.

// We will use the integers 0, 1, and 2 to represent the color red, white, and blue, respectively.

// You must solve this problem without using the library's sort function.



namespace LeetCodeProblems;
public partial class LCProblems
{
    public void SortColors(int[] nums)
    {
        int[] count = new int[3];

        foreach (int n in nums)
        {
            if (count[n] == null)
            {
                count[n] = 1;
            }
            else
            {
                count[n]++;
            }
        }
        int j = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            while (count[j] == 0)
            {
                j++;
            }
            nums[i] = j;
            count[j]--;
        }
        return;
    }
}