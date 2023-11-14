// 416.Partition Equal Subset Sum
// Medium
// 11.7K
// 214
// Companies
// Given an integer array nums, return true if you can partition the array into two subsets such that the sum of the elements in both subsets is equal or false otherwise.
namespace LeetCodeProblems;
public partial class LCProblems
{
    public bool CanPartition(int[] nums)
    {
        int sum = nums.Sum();
        if (sum % 2 != 0)
        {
            return false;
        }

        HashSet<int> hs = new HashSet<int>();
        hs.Add(0);
        foreach (int n in nums)
        {
            HashSet<int> temp = new HashSet<int>(hs);
            foreach (int t in hs)
            {
                temp.Add(t + n);
            }
            hs = temp;
        }
        return hs.Contains(sum / 2);

    }
}