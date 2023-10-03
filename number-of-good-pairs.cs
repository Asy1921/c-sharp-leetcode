// 1512.Number of Good Pairs
// Easy
// 4.6K
// 209
// Companies
// Given an array of integers nums, return the number of good pairs.

// A pair (i, j) is called good if nums[i] == nums[j] and i<j.
namespace LeetCodeProblems;
public partial class LCProblems
{

    public int NumIdenticalPairs(int[] nums)
    {
        int goodpairs = 0;
        int l = 0;
        int r = nums.Length - 1;
        while (l < nums.Length - 1)
        {
            r = nums.Length - 1;
            while (l < r)
            {
                if (l < r && nums[l] == nums[r])
                {
                    goodpairs++;
                }
                r--;
            }
            l++;
        }
        return goodpairs;

    }
}
