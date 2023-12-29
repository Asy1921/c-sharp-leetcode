// 2215. Find the Difference of Two Arrays
// Easy
// 2.1K
// 87
// Companies
// Given two 0-indexed integer arrays nums1 and nums2, return a list answer of size 2 where:

// answer[0] is a list of all distinct integers in nums1 which are not present in nums2.
// answer[1] is a list of all distinct integers in nums2 which are not present in nums1.
// Note that the integers in the lists may be returned in any order.


namespace LeetCodeProblems;
public partial class LCProblems
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        List<IList<int>> res = new List<IList<int>>();
        HashSet<int> hs1 = new HashSet<int>();
        HashSet<int> hs2 = new HashSet<int>();
        res.Add(new List<int>());
        res.Add(new List<int>());
        for (int i = 0; i < nums1.Length; i++)
        {
            if (!nums2.Contains(nums1[i]) && !res[0].Contains(nums1[i]))
            {
                res[0].Add(nums1[i]);
            }

        }
        for (int i = 0; i < nums2.Length; i++)
        {
            if (!nums1.Contains(nums2[i]) && !res[1].Contains(nums2[i]))
            {
                res[1].Add(nums2[i]);
            }
        }
        return res;

    }
}