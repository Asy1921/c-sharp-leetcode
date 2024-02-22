// 997. Find the Town Judge
// Solved
// Easy
// Topics
// Companies
// In a town, there are n people labeled from 1 to n. There is a rumor that one of these people is secretly the town judge.

// If the town judge exists, then:

// The town judge trusts nobody.
// Everybody (except for the town judge) trusts the town judge.
// There is exactly one person that satisfies properties 1 and 2.
// You are given an array trust where trust[i] = [ai, bi] representing that the person labeled ai trusts the person labeled bi. If a trust relationship does not exist in trust array, then such a trust relationship does not exist.

// Return the label of the town judge if the town judge exists and can be identified, or return -1 otherwise.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int FindJudge(int n, int[][] trust)
    {
        HashSet<int> l = new HashSet<int>();
        for (int i = 1; i <= n; i++)
        { l.Add(i); }
        for (int i = 0; i < trust.Length; i++)
        {
            if (l.Contains(trust[i][0]))
            {
                l.Remove(trust[i][0]);
            }
        }
        if (l.Count() == 0)
        {
            return -1;
        }
        int res = l.First();
        for (int i = 1; i <= n; i++)
        { l.Add(i); }
        for (int i = 0; i < trust.Length; i++)
        {
            if (res == trust[i][1])
            {
                l.Remove(trust[i][0]);
            }
        }
        if (l.Count == 1 && l.First() == res)
            return res;
        return -1;

    }
}