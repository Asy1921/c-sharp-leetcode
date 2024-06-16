// 1122.Relative Sort Array
// Solved
// Easy
// Topics
// Companies
// Hint
// Given two arrays arr1 and arr2, the elements of arr2 are distinct, and all elements in arr2 are also in arr1.

// Sort the elements of arr1 such that the relative ordering of items in arr1 are the same as in arr2. Elements that do not appear in arr2 should be placed at the end of arr1 in ascending order.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int[] RelativeSortArray(int[] arr1, int[] arr2)
    {
        Dictionary<int, int> map = new();
        int[] res = new int[arr1.Length];
        List<int> rem = new List<int>();

        foreach (int n in arr2)
        {
            map.Add(n, 0);
        }
        foreach (int n in arr1)
        {
            if (map.ContainsKey(n))
            {
                map[n]++;
            }
            else
            {
                rem.Add(n);

            }
        };
        rem.Sort();
        int i = 0;
        foreach (int n in arr2)
        {
            if (map[n] > 0)
            {
                while ((map[n]--) > 0)
                {
                    res[i++] = n;
                }
            }
        }
        foreach (int n in rem)
        {
            res[i++] = n;
        }
        return res;
    }
}