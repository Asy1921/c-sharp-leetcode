// 1481. Least Number of Unique Integers after K Removals
// Solved
// Medium
// Topics
// Companies
// Hint
// Given an array of integers arr and an integer k. Find the least number of unique integers after removing exactly k elements.


namespace LeetCodeProblems;
public partial class LCProblems
{
    public int FindLeastNumOfUniqueInts(int[] arr, int k)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        foreach (int n in arr)
        {
            if (map.ContainsKey(n))
            {
                map[n]++;
            }
            else
            {
                map.Add(n, 1);
            }
        }
        var sortedDict = from entry in map orderby entry.Value ascending select entry;
        foreach (var kvp in sortedDict)
        {
            if (k > 0)
            {
                if (k >= kvp.Value)
                {
                    k -= kvp.Value;
                    map.Remove(kvp.Key);
                }
                else
                {
                    map[kvp.Key] -= k;
                    k = 0;
                }
            }
            else
            {
                break;
            }
        }



        return map.Count();

    }
}