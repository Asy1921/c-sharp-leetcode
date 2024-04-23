// 1282. Group the People Given the Group Size They Belong To
// Solved
// Medium
// Topics
// Companies
// Hint
// There are n people that are split into some unknown number of groups. Each person is labeled with a unique ID from 0 to n - 1.

// You are given an integer array groupSizes, where groupSizes[i] is the size of the group that person i is in. For example, if groupSizes[1] = 3, then person 1 must be in a group of size 3.

// Return a list of groups such that each person i is in a group of size groupSizes[i].

// Each person should appear in exactly one group, and every person must be in a group. If there are multiple answers, return any of them. It is guaranteed that there will be at least one valid solution for the given input.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public IList<IList<int>> GroupThePeople(int[] g)
    {
        List<IList<int>> res = new();
        Dictionary<int, List<int>> map = new();
        for (int i = 0; i < g.Length; i++)
        {
            if (map.ContainsKey(g[i]))
            {
                map[g[i]].Add(i);
            }
            else
            {
                map.Add(g[i], new List<int>() { i });
            }
            if (map[g[i]].Count() == g[i])
            {
                res.Add(new List<int>(map[g[i]]));
                map[g[i]] = new List<int>();
            }
        }
        return res;
    }
}