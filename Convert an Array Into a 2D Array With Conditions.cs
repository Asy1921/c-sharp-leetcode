// 2610. Convert an Array Into a 2D Array With Conditions
// Medium
// 1.1K
// 49
// Companies
// You are given an integer array nums. You need to create a 2D array from nums satisfying the following conditions:

// The 2D array should contain only the elements of the array nums.
// Each row in the 2D array contains distinct integers.
// The number of rows in the 2D array should be minimal.
// Return the resulting array. If there are multiple answers, return any of them.

// Note that the 2D array can have a different number of elements on each row.


namespace LeetCodeProblems;
public partial class LCProblems
{
    public IList<IList<int>> FindMatrix(int[] nums)
    {
        List<IList<int>> res = new List<IList<int>>();
        for (int i = 0; i < nums.Length; i++)
        {
            bool inserted = false;
            foreach (List<int> row in res)
            {
                if (!row.Contains(nums[i]))
                {
                    row.Add(nums[i]);
                    inserted = true;
                    break;
                }

            }
            if (!inserted)
            {
                res.Add(new List<int> { nums[i] });
            }
        }
        return res;
    }
}