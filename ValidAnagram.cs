// 242. Valid Anagram
// Easy
// 11.3K
// 355
// Companies
// Given two strings s and t, return true if t is an anagram of s, and false otherwise.

// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        Span<int> usedS = stackalloc int[26];
        Span<int> usedT = stackalloc int[26];

        for (int i = 0; i < s.Length; i++)
        {
            usedS[s[i] - 97]++;
            usedT[t[i] - 97]++;
        }


        return usedS.SequenceEqual(usedT);
    }
}