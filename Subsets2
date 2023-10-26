//90. Subsets II
//Medium
//9.2K
//258
//Companies
//Given an integer array nums that may contain duplicates, return all possible 
//subsets
// (the power set).

//The solution set must not contain duplicate subsets. Return the solution in any order.

namespace LeetCodeProblems;
public partial class LCProblems
{
public IList<IList<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        List<IList<int>> res=new List<IList<int>>();

        void AddSubsets(int i,List<int> subset)
        {
            if(i==nums.Length)
            {
                res.Add(new List<int>(subset));
                return;
            }
            subset.Add(nums[i]);
            AddSubsets(i+1,subset);
            subset.RemoveAt(subset.Count-1);
            while(i+1<nums.Length && nums[i]==nums[i+1])
            {
                i++;
            }
            AddSubsets(i+1,subset);
        }
        AddSubsets(0,new List<int>());
        return res;
    }
}

 
