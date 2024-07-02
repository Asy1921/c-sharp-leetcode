// 350. Intersection of Two Arrays II
// Solved
// Easy
// Topics
// Companies
// Given two integer arrays nums1 and nums2, return an array of their intersection. Each element in the result must appear as many times as it shows in both arrays and you may return the result in any order.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        Dictionary<int, int> hm = new();
        foreach (int n in nums1)
        {
            if (hm.ContainsKey(n))
            {
                hm[n]++;
            }
            else
            {
                hm.Add(n, 1);
            }
        }
        List<int> res = new();
        foreach (int n in nums2)
        {
            if (hm.ContainsKey(n) && hm[n] > 0)
            {
                res.Add(n);
                hm[n]--;
            }

        }
        return res.ToArray();
    }
}