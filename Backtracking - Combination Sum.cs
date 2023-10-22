// <!-- 39. Combination Sum
// Medium
// 17.7K
// 359
// Companies
// Given an array of distinct integers candidates and a target integer target, return a list of all unique combinations of candidates where the chosen numbers sum to target. You may return the combinations in any order.

// The same number may be chosen from candidates an unlimited number of times. Two combinations are unique if the 
// frequency
//  of at least one of the chosen numbers is different.

// The test cases are generated such that the number of unique combinations that sum up to target is less than 150 combinations for the given input. -->

namespace LeetCodeProblems;
public partial class LCProblems
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        List<IList<int>> res = new List<IList<int>>();

        void SearchRes(int i, List<int> li, int tot)
        {
            if (tot == target)
            {
                res.Add(new List<int>(li));
                return;
            }
            if (i >= candidates.Length || tot > target)
            {
                return;
            }

            li.Add(candidates[i]);
            SearchRes(i, li, tot + candidates[i]);
            li.RemoveAt(li.Count - 1);
            SearchRes(i + 1, li, tot);
        }

        SearchRes(0, new List<int>(), 0);
        return res;
    }
}
