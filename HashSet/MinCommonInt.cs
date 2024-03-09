// 2540. Minimum Common Value
// Solved
// Easy
// Topics
// Companies
// Hint
// Given two integer arrays nums1 and nums2, sorted in non-decreasing order, return the minimum integer common to both arrays. If there is no common integer amongst nums1 and nums2, return -1.

// Note that an integer is said to be common to nums1 and nums2 if both arrays have at least one occurrence of that integer.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int GetCommon(int[] nums1, int[] nums2)
    {
        HashSet<int> set = new HashSet<int>(nums1);

        foreach (int num in nums2)
        {
            if (set.Contains(num))
            {
                return num;
            }
        }

        return -1;

    }
}