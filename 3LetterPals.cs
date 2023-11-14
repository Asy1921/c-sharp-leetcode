// 1930.Unique Length - 3 Palindromic Subsequences
// Medium
// 1.4K
// 58
// Companies
// Given a string s, return the number of unique palindromes of length three that are a subsequence of s.

// Note that even if there are multiple ways to obtain the same subsequence, it is still only counted once.

// A palindrome is a string that reads the same forwards and backwards.

// A subsequence of a string is a new string generated from the original string with some characters (can be none) deleted without changing the relative order of the remaining characters.

// For example, "ace" is a subsequence of "abcde".
namespace LeetCodeProblems;
public partial class LCProblems
{
    public int CountPalindromicSubsequence(string s)
    {
        int count = 0;

        for (char c = 'a'; c <= 'z'; c++)
        {
            int first = -1, second = -1;

            // Find the first occurrence of the current character
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    first = i;
                    break;
                }
            }

            // Find the second occurrence of the current character after the first occurrence
            for (int i = first + 1; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    second = i;

                }
            }

            // If both occurrences are found, increment the count
            if (first != -1 && second != -1)
            {
                count += CountBetween(s, c, first, second);
            }
        }

        return count;
    }

    private int CountBetween(string s, char c, int first, int second)
    {

        HashSet<char> hs = new HashSet<char>();
        for (int i = first + 1; i < second; i++)
        {
            hs.Add(s[i]);
        }

        return hs.Count();
    }
}