// 647.Palindromic Substrings
// Medium
// 9.8K
// 206
// Companies
// Given a string s, return the number of palindromic substrings in it.

// A string is a palindrome when it reads the same backward as forward.

// A substring is a contiguous sequence of characters within the string.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public int CountSubstrings(string s)
    {
        int palCount = 0;
        void CountPals(int l, int r)
        {
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                palCount++;
                l--;
                r++;
            }
        }

        for (int i = 0; i < s.Length; i++)
        {
            CountPals(i, i);
            CountPals(i, i + 1);
        }
        return palCount;

    }
}