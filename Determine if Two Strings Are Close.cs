// 1657. Determine if Two Strings Are Close
// Medium
// Topics
// Companies
// Hint
// Two strings are considered close if you can attain one from the other using the following operations:

// Operation 1: Swap any two existing characters.
// For example, abcde -> aecdb
// Operation 2: Transform every occurrence of one existing character into another existing character, and do the same with the other character.
// For example, aacabb -> bbcbaa (all a's turn into b's, and all b's turn into a's)
// You can use the operations on either string as many times as necessary.

// Given two strings, s and t, return true if s and t are close, and false otherwise.
namespace LeetCodeProblems;
public partial class LCProblems
{
    public bool CloseStrings(string s, string t)
    {
        int l1 = s.Length, l2 = t.Length;
        if (l1 != l2) return false;
        if (s.Equals(t)) return true;

        int[] map1 = new int[26];
        int[] map2 = new int[26];

        for (int i = 0; i < l1; i++)
        {
            map1[s[i] - 'a']++;
        }

        for (int i = 0; i < l2; i++)
        {
            if (map1[t[i] - 'a'] == 0) return false;
            map2[t[i] - 'a']++;
        }

        Array.Sort(map1);
        Array.Sort(map2);

        for (int i = 25; i >= 0 && map1[i] != 0; i--)
        {
            if (map1[i] != map2[i])
            {
                return false;
            }
        }

        return true;
    }
}