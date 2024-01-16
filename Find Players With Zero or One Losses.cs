// 2225. Find Players With Zero or One Losses
// Solved
// Medium
// Topics
// Companies
// Hint
// You are given an integer array matches where matches[i] = [winneri, loseri] indicates that the player winneri defeated player loseri in a match.

// Return a list answer of size 2 where:

// answer[0] is a list of all players that have not lost any matches.
// answer[1] is a list of all players that have lost exactly one match.
// The values in the two lists should be returned in increasing order.

// Note:

// You should only consider the players that have played at least one match.
// The testcases will be generated such that no two matches will have the same outcome.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public IList<IList<int>> FindWinners(int[][] matches)
    {
        SortedDictionary<int, int> map = new SortedDictionary<int, int>();
        foreach (int[] score in matches)
        {
            if (!map.ContainsKey(score[0]))
            {

                map.Add(score[0], 0);
            }
            if (map.ContainsKey(score[1]))
            {
                map[score[1]]++;
            }
            else
            {
                map.Add(score[1], 1);
            }
        }
        List<IList<int>> res = new List<IList<int>>();
        List<int> notLost = new List<int>();
        List<int> lostone = new List<int>();

        foreach (KeyValuePair<int, int> kvp in map)
        {
            if (kvp.Value == 0)
            {
                notLost.Add(kvp.Key);
            }
            else if (kvp.Value == 1)
            {
                lostone.Add(kvp.Key);
            }
        }
        res.Add(notLost);
        res.Add(lostone);
        return res;


    }
}