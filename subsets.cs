// 78.Subsets
// Medium
// 16K
// 235
// Companies
// Given an integer array nums of unique elements, return all possible 
// subsets
//  (the power set).

// The solution set must not contain duplicate subsets. Return the solution in any order.
namespace LeetCodeProblems;
public partial class LCProblems
{
    public void CalcSubsets(int[] arr, List<IList<int>> subsets, List<int> subset, int i)
    {
        subsets.Add(new List<int>(subset));

        for (int p = i; p < arr.Length; p++)
        {
            subset.Add(arr[p]);
            CalcSubsets(arr, subsets, subset, p + 1);
            subset.RemoveAt(subset.Count - 1);
        }
    }

    public IList<IList<int>> Subsets(int[] nums)
    {
        List<IList<int>> subsets = new List<IList<int>>();
        List<int> subset = new List<int>();
        CalcSubsets(nums, subsets, subset, 0);
        return subsets;
    }
}