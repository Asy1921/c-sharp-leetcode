// 5.Longest Palindromic Substring
// Medium
// 27.9K
// 1.7K
// Companies
// Given a string s, return the longest 
// palindromic

// substring
//  in s.
namespace LeetCodeProblems;

public partial class LCProblems
{

    public string palSubString = "";
    public string LongestPalindrome(string s)
    {
        for (int i = 0; i < s.Length; i++)
        {
            // For Odd
            {
                checkPal(i, i + 1, s);
            }

            {
                checkPal(i, i, s);
            }
        }
        return palSubString;
    }
    public void checkPal(int l, int r, string s)
    {
        while (l >= 0 && r < s.Length && s[l] == s[r])
        {
            if (r - l + 1 > palSubString.Length)
            {
                {
                    palSubString = s.Substring(l, r - l + 1);
                }
            }
            l--;
            r++;
        }
    }


}