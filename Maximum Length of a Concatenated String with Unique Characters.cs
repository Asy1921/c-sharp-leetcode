// 1239. Maximum Length of a Concatenated String with Unique Characters
// Solved
// Medium
// Topics
// Companies
// Hint
// You are given an array of strings arr. A string s is formed by the concatenation of a subsequence of arr that has unique characters.

// Return the maximum possible length of s.

// A subsequence is an array that can be derived from another array by deleting some or no elements without changing the order of the remaining elements.


namespace LeetCodeProblems;
public partial class LCProblems
{
    public bool HasUnique(string s)
    {
        HashSet<char> set = new HashSet<char>();
        foreach (char c in s)
        {
            if (!set.Add(c))
            {
                return false;
            }

        }
        return true;
    }
    public int MaxLength(IList<string> arr)
    {
        int res = 0;
        var combinations = Enumerable.Range(0, 1 << (arr.Count)).Select(index => arr.Where((v, i) => (index & (1 << i)) != 0).ToArray());

        foreach (var c in combinations)
        {
            string temp = string.Join("", c);
            if (HasUnique(temp))
            { res = Math.Max(res, temp.Length); }
        }
        return res;

    }
}