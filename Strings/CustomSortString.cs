// 791. Custom Sort String
// Solved
// Medium
// Topics
// Companies
// You are given two strings order and s. All the characters of order are unique and were sorted in some custom order previously.

// Permute the characters of s so that they match the order that order was sorted. More specifically, if a character x occurs before a character y in order, then x should occur before y in the permuted string.

// Return any permutation of s that satisfies this property.
namespace LeetCodeProblems;
public partial class LCProblems
{
    public string CustomSortString(string order, string s)
    {
        int[] freq = new int[26];
        for (int i = 0; i < 26; i++)
        {
            freq[i] = 0;
        }
        foreach (char c in s)
        {
            freq[c - 'a']++;
        }
        string res = "";
        foreach (char c in order)
        {
            if (freq[c - 'a'] > 0)
            {
                while (freq[c - 'a'] > 0)
                {
                    res += c;
                    freq[c - 'a']--;
                }
            }
        }
        for (int i = 0; i < 26; i++)
        {
            if (freq[i] > 0)
            {
                while (freq[i] > 0)
                {
                    res += (char)(i + 'a');
                    freq[i]--;
                }
            }
        }
        return res;
    }
}
