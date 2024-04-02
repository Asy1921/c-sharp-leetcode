// 205. Isomorphic Strings
// Solved
// Easy
// Topics
// Companies
// Given two strings s and t, determine if they are isomorphic.

// Two strings s and t are isomorphic if the characters in s can be replaced to get t.

// All occurrences of a character must be replaced with another character while preserving the order of characters. No two characters may map to the same character, but a character may map to itself.
namespace LeetCodeProblems;
public partial class LCProblems
{
    public bool IsIsomorphic(string s, string t)
    {
        Dictionary<char, char> map = new Dictionary<char, char>();
        for (var i = 0; i < s.Length; i++)
        {
            if (map.TryGetValue(s[i], out char pair))
            {
                if (pair != t[i])
                {
                    return false;
                }
                continue;
            }
            if (map.ContainsValue(t[i]))
            {
                return false;
            }
            map.Add(s[i], t[i]);
        }
        return true;
    }
}