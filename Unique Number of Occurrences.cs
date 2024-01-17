// 1207. Unique Number of Occurrences
// Solved
// Easy
// Topics
// Companies
// Hint
// Given an array of integers arr, return true if the number of occurrences of each value in the array is unique or false otherwise.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public bool UniqueOccurrences(int[] arr)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        HashSet<int> occMap = new HashSet<int>();

        foreach (int n in arr)
        {
            map[n] = map.GetValueOrDefault(n, 0) + 1;
        }

        foreach (int n in map.Values)
        {
            if (!occMap.Add(n))
            {
                return false;
            }
        }

        return true;
    }
}