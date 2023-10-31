// 40. Combination Sum II
// Medium
// 9.8K
// 251
// Companies
// Given a collection of candidate numbers (candidates) and a target number (target), find all unique combinations in candidates where the candidate numbers sum to target.

// Each number in candidates may only be used once in the combination.

// Note: The solution set must not contain duplicate combinations.


namespace LeetCodeProblems;
public partial class LCProblems
{
    public IList<IList<int>> CombinationSum2(int[] c, int target)
    {
        List<IList<int>> res = new List<IList<int>>();

        void backtrack(List<int> cur, int i, int sum)
        {
            if (sum == target)
            {
                res.Add(new List<int>(cur));
                return;
            }
            if (i >= c.Length || sum > target)
            {
                return;
            }

            cur.Add(c[i]);
            backtrack(cur, i + 1, sum + c[i]);
            cur.RemoveAt(cur.Count - 1);
            while (i + 1 < c.Length && c[i] == c[i + 1])
            {
                i++;
            }
            backtrack(cur, i + 1, sum);
        }
        Array.Sort(c);
        backtrack(new List<int>(), 0, 0);
        return res;
    }
}