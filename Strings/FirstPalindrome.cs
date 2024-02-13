// 2108. Find First Palindromic String in the Array
// Solved
// Easy
// Topics
// Companies
// Hint
// Given an array of strings words, return the first palindromic string in the array. If there is no such string, return an empty string "".

// A string is palindromic if it reads the same forward and backward.

namespace LeetCodeProblems;
public partial class LCProblems
{
    public string FirstPalindrome(string[] words)
    {
        foreach (string s in words)
        {
            int i = 0;
            int j = s.Length - 1;
            bool isPal = true;
            while (i < j)
            {
                if (s[i] != s[j])
                {
                    isPal = false;
                    break;
                }
                i++;
                j--;
            }
            if (isPal)
            {
                return s;
            }

        }
        return "";
    }
}